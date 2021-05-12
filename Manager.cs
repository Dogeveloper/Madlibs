using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
    public class Manager
    {
        private static Manager singleton = new Manager();
        private bool IsOpening = false;

        private Manager()
        {

        }

        public static Manager Get()
        {
            return singleton;
        }

        public string GetFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mad Lib Files|*.madlib";
            ofd.Title = "Mad Lib Selection";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                var stream = ofd.OpenFile();

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            else
            {
                IsOpening = false;
                return "";
            }
        }

        public void OpenMadLib(string text = "")
        {
            if (!IsOpening)
            {
                IsOpening = true;
                if (text == "")
                {
                    string s1 = GetFromFile();
                    if(s1 != "")
                    {
                        text = s1;
                    }
                    else
                    {
                        return;
                    }
                }

                Regex r = new Regex(@"\{.*?\}");
                MatchCollection matches = r.Matches(text);
                Dictionary<string, string> replacers = new Dictionary<string, string>();
                foreach (var s in matches)
                  {
                    string friendly = s.ToString().Replace("{", "").Replace("}", "");
                    MadLibQuestion e = new MadLibQuestion();
                    e.Text = friendly;
                    e.QuestionLabel.Text = friendly;
                    e.Show();

                    e.ButtonContinue.Click += delegate
                    {
                        replacers.Add(s.ToString(), e.textBox1.Text);
                        if(replacers.Count == matches.Count)
                        {
                            string newtext = text;
                            foreach(KeyValuePair<string, string> entry in replacers) {
                                newtext = newtext.Replace(entry.Key, entry.Value);
                            }
                            MadLibOutput output = new MadLibOutput();

                            output.OutputText.Text = newtext;
                            output.Show();
                            IsOpening = false;
                        }
                        e.Close();
                    };

                }
                
            }
            else
            {
                MessageBox.Show("You have already opened a mad lib.", "Mad Lib Already Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
