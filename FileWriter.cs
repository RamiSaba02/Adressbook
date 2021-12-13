using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Inlämningsupggift_final_version
{
    class FileWriter
    {
        private string locationOfFile = "Addressbok.txt";

        internal List<ContactGetter> GetAllContactsFromFile()
        {
            var contacts = new List<ContactGetter>();

            if (File.Exists(locationOfFile))
            {
                using (StreamReader sr = File.OpenText(locationOfFile))
                {
                    string isLineEmpty;
                    while ((isLineEmpty = sr.ReadLine()) != null)
                    {
                        string[] newInfo = isLineEmpty.Split(',');
                        var contact = new ContactGetter
                        {
                            Name = newInfo[0],
                            Street = newInfo[1],
                            Zip = newInfo[2],
                            Area = newInfo[3],
                            Tel = newInfo[4],
                            Email = newInfo[5]
                        };
                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }

        public void Updater(List<ContactGetter> Updater)
        {
            if (File.Exists(locationOfFile))
                File.Delete(locationOfFile);

            using (TextWriter tW = File.CreateText(locationOfFile))
            {

                foreach (var info in Updater)
                {
                    string newAddress = $"{info.Name},{info.Street},{info.Zip},{info.Area},{info.Tel},{info.Email}";
                    tW.WriteLine(newAddress);
                }
            }
        }
    }
}
}
