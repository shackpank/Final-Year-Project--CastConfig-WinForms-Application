using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace WindowsApplication1
{
    public partial class cmConfigForm : Form
    {
        private string ConfigFileName = "./config.py";
        private Boolean FirstRun = false;

        public cmConfigForm()
        {
            InitializeComponent();
        }

        private void cmConfigForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(this.ConfigFileName))
            {
                // Config.py exists already in this folder, we're changing settings not
                // creating a new file.
                this.FirstRun = false;
                scanConfig(sender);
            }
            else
            {
                // No config.py - likely first time application is run. Auto-check the rescan
                // box as the database should be empty too.
                this.FirstRun = true;
                rescan.Checked = true;

                // Set defaults
                connectionAccept.SelectedIndex = 0;
                transcodeMethod.SelectedIndex = 0;
                configStatus.Text = "Please confirm initial settings below, before the application scans for supported files";
            }
        }

        private string scanConfig(object sender)
        {
            // Going to be a bit trickier this one, probably will end up writing
            // some rubbish hacks or quick text-processing routines, instantiating the damn
            // thing as a Python object and querying it for its properties is not an option.
            // Because this is c#. Hurf durf.
            TextReader tr = new StreamReader(this.ConfigFileName);

            string WorkingLine;

            // # autogenerated by the .NET tool
            WorkingLine = tr.ReadLine();
            if (WorkingLine != "# autogenerated by the .NET tool")
            {
                // Not very friendly... but time is tight.
                MessageBox.Show("Config file config.py could not be read. Either make changes in a text editor or delete it and restart this application to make a new one", "Config file unreadable");
                return "no";
            }

            // import statement
            WorkingLine = tr.ReadLine();
            // class definition
            WorkingLine = tr.ReadLine();

            // Going to be very cheap here and split on single quotes to extract what
            // we want, and hope that at no point anybody with say, the username Jim O'Neill
            // ever uses this application
            string[] SplitString;

            // media path! Now we're getting serious!
            WorkingLine = tr.ReadLine();
            SplitString = WorkingLine.Split('\'');
            mediaPath.Text = SplitString[1];
            folderBrowser.SelectedPath = SplitString[1];
            
            // transcode, yes/no?
            WorkingLine = tr.ReadLine();
            if (WorkingLine == "  transcode = True") 
            {
                transcode.Checked = true;
            } 
            else 
            {
                transcode.Checked = false;
            }

            // which codec?
            WorkingLine = tr.ReadLine();
            if (WorkingLine == "  transcode_codec = 'libx264'")
            {
                transcodeMethod.SelectedIndex = 0;
            }
            else
            {
                transcodeMethod.SelectedIndex = 1;
            }

            // which port?
            WorkingLine = tr.ReadLine();
            string Port = WorkingLine.Remove(0, 16);
            listenPort.Text = Port;

            // which host?
            WorkingLine = tr.ReadLine();
            SplitString = WorkingLine.Split('\'');
            if( SplitString[1] == "0.0.0.0") 
            {
                connectionAccept.SelectedIndex = 0;
            }
            else {
                connectionAccept.SelectedIndex = 1;
            }

            
            // authenticate?
            WorkingLine = tr.ReadLine();
            if (WorkingLine == "  authenticate = False")
            {
                authRequired.Checked = false;
            }
            else
            {
                authRequired.Checked = true;
            }
            // username?
            WorkingLine = tr.ReadLine();
            SplitString = WorkingLine.Split('\'');
            authUser.Text = SplitString[1];

            // password?
            WorkingLine = tr.ReadLine();
            SplitString = WorkingLine.Split('\'');
            authPw.Text = authPwConfirm.Text = SplitString[1];

            // Don't care about any remaining lines. Don't care one bit.
            tr.Close();

            return "ok";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // saveConfig() does a lot of validation and mashes a bunch of strings together
            // to produce a valid Python file... lets keep the complicated bits out of here
            string Config;
            Config = saveConfig(sender);

            // if it's "no", saveConfig() found an error. Probably a copout way of going about
            // things, but hey, I'm used to languages that don't force a return type
            if (Config != "no")
            {
                // Dump whatever saveConfig() gives us to the config file
                TextWriter tw = new StreamWriter(this.ConfigFileName);
                tw.Write(Config);
                tw.Close();

                // The zip file libraries for C# are rubbish
                // Wrote a tiny python app to handle adding the config to the zip file
                Process ci = new Process();
                ci.StartInfo.FileName = "importconfig.exe";
                ci.Start();
                ci.WaitForExit();

                File.Delete(this.ConfigFileName);
				
                // Do we need to rescan?
                Boolean ScanMedia = false;
                if (!rescan.Checked)
                {
                    // Make sure people know what they're in for if they play with the options
                    // and end up unchecking that one.
                    if (this.FirstRun)
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you don't want to scan the media library? Until " + folderBrowser.SelectedPath + " has been scanned no pictures, music or videos will show up in the application", "Are you sure?", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.No)
                        {
                            // Everybody gets one
                            ScanMedia = true;
                        }
                    }
                }
                else
                {
                    // Box is ticked, of course we should rescan
                    ScanMedia = true;
                }
                if (ScanMedia)
                {
                    // Fair warning, it **will** take some time.
                    // Information ain't free buddy, it'll cost you disk reads and http requests
                    MessageBox.Show("The application will now scan " + folderBrowser.SelectedPath + " for supported files - this may take some time depending on how many new files it finds. This window will close itself when the process has finished");

                    // Run the scanner process, wait for it to finish
                    Process scanner = new Process();
                    scanner.StartInfo.FileName = "scanner.exe";
                    scanner.Start();
                    scanner.WaitForExit();

                    // Open the main application
                    Process cast = new Process();
                    cast.StartInfo.FileName = "cast.exe";
                    cast.StartInfo.CreateNoWindow = true;
                    cast.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    cast.Start();
                    
                    System.Threading.Thread.Sleep(5000);
                    MessageBox.Show("The application will now open in your default browser");

                    // Open a new browser window pointing to it
                    System.Diagnostics.Process.Start("http://127.0.0.1:" + listenPort.Text + "/");
                }

                this.Close();
            }

        }

        private void chooseLocation_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowser.ShowDialog();
            if (dr == DialogResult.OK)
            {
                // Apparently I can't do mediaPath.Font.Bold = false? Eh, didnt take too long
                // to work out exactly what level of mental object-orientedness C# wanted out of me.
                // Replacing the Font object with an extension of the original Font object extended
                // with a new FontStyle object. Classy!
                mediaPath.Font = new Font(mediaPath.Font, FontStyle.Regular);
                mediaPath.Text = folderBrowser.SelectedPath;
            }
        }

        private string saveConfig(object sender)
        {
            // Lets go! This config tool has the bare bones of the config.py file I was using in
            // development to control stuff like where media files are, what IP and port to listen
            // on, whether to ask for authentication, etc etc. We're gonna build it up line by line
            // based on which options the user chose in this here form.
            string Config;
            Config = "# autogenerated by the .NET tool\n";
            Config += "import os, sys\n";
            Config += "class CastConfig( object):\n";

            // First thing's first. Where are the files at? If the Python bit of Cast does not know at where the
            // files are, it will be quite, quite useless. Much like my grammar there.
            string FolderPath;
            FolderPath = folderBrowser.SelectedPath;
            if (FolderPath != "")
            {
                Config += "  media_path = '" + FolderPath.Replace('\\', '/') + "'\n";
            }
            else
            {
                // User hasn't picked a path. Bad user.
                MessageBox.Show("Please choose a valid path the application should search for media files");
                return "no";
            }

            // Transcode settings. Recommend these stay switched off - it is clever but slow as
            // heck. Flash 9+ can decompress h264, and compressing it is slow even on relatively modern
            // Core 2 Duo chips, my laptop does about 10 FPS
            string TranscodeSetting;
            if( transcode.Checked == true) 
            {
                TranscodeSetting = "True";
            } 
            else 
            {
                TranscodeSetting = "False";
            }
	        Config += "  transcode = " + TranscodeSetting + "\n";

            string TranscodeMethodSetting;
            if (transcodeMethod.SelectedIndex == 0)
            {
                TranscodeMethodSetting = "libx264";
            }
            else
            {
                TranscodeMethodSetting = "copy";
            }
	        Config += "  transcode_codec = '" + TranscodeMethodSetting + "'\n";

            // Which port to listen on? Just user configurable because I can, doesn't make
            // masses of difference. Want an integer between 1 & 32768, but perform the tests on
            // a temporary variable so I don't have to stringify it again at the end
            string ListenPortSetting = listenPort.Text;
            int TempInt;
            if (int.TryParse(ListenPortSetting, out TempInt))
            {
                if (TempInt > 1 && TempInt < 32768)
                {
                    Config += "  listen_port = " + ListenPortSetting + "\n";
                }
                else
                {
                    MessageBox.Show("The port must be between 2 and 32767");
                    return "no";
                }
            }
            else
            {
                MessageBox.Show("The port this application listens on must be a number");
                return "no";
            }

            // Which host to listen on. Keeping this simple, either localhost, or any address.
            // localhost is a bit more secure but also more limited.
            string ListenHostSetting;
            if (connectionAccept.SelectedIndex == 0)
            {
                ListenHostSetting = "0.0.0.0";
            }
            else
            {
                ListenHostSetting = "127.0.0.1";
            }
	        Config += "  listen_host = '" + ListenHostSetting + "'\n";

            // Authentication. If you've got all ports forwarded and stuff you probably don't want
            // just anyone to be able to do whatever.
            string AuthenticationRequired, Username, Password;
            if (authRequired.Checked)
            {
                AuthenticationRequired = "True";
                // Need both a username and password if you want authentication
                if (authUser.Text != "" && authPw.Text != "")
                {
                    // And to pass the check thing to stop people misspelling stuff
                    if (authPw.Text != authPwConfirm.Text)
                    {
                        MessageBox.Show("Passwords don't match");
                        return "no";
                    }
                    else
                    {
                        Username = authUser.Text;
                        Password = authPw.Text;
                    }
                }
                else
                {
                    MessageBox.Show("If you want authentication you must enter a username and a password");
                    return "no";
                }
            }
            else
            {
                // Doesnt even matter
                AuthenticationRequired = "False";
                Username = "";
                Password = "";
            }
	        Config += "  authenticate = " + AuthenticationRequired + "\n";
	        Config += "  username = '" + Username + "'\n";
	        Config += "  password = '" + Password + "'\n";
	
            // Editable if you change the file but not really recommended
	        Config += "  handler_path = 'handlers/'\n";
	        Config += "  lib_path = 'lib/'\n";
        	Config += "  db_name = 'db/media.s3db'\n";
	        
            // Last few lines I promise
        	Config += "  def path(self):\n";
		    Config += "    handler_path = os.path.abspath( CastConfig.handler_path )\n";
            Config += "    sys.path.append( handler_path )\n";

            // Ta da! the contents of Config can be processed by Python when the WSGI
            // web server starts.
            return Config;
        }
    }
}