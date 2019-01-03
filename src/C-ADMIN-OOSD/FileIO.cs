using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_ADMIN_OOSD
{
    public class FileIO
    {
        //Create public strings
        //Use this string to identify things
        public static string Name = "";
        //ProgramDIR
        public static string localD = Environment.CurrentDirectory;
        //Main data DIR
        public static string localAD = Path.Combine(localD, "Data");
        //Packages DIR
        public static string localPD = Path.Combine(localAD, "Packages");
        //Products DIR
        public static string localPrD = Path.Combine(localAD, "Products");
        //Product Suppliers DIR
        public static string localPrsD = Path.Combine(localAD, "ProductSuppliers");
        //Suppliers DIR
        public static string localSD = Path.Combine(localAD, "Suppliers");
        //Packages Product Suppliers DIR
        public static string localPpsD = Path.Combine(localAD, "PackagesProductSuppliers");
        public static void initDIR()
        {
            //Make DIRs
            Directory.CreateDirectory(localAD);
            //Directory.CreateDirectory(localPD);
            //Directory.CreateDirectory(localPrD);
            //Directory.CreateDirectory(localPrsD);
            //Directory.CreateDirectory(localSD);
            //Directory.CreateDirectory(localPpsD);
        }
        public static bool fileIsThere(string file)
        {
            bool result = false;
            if(File.Exists(file) == true)
            {
                result = true;
            }
            return result;
        }
        //Save content to file
        public static void save(string id, List<string> content)
        {
            string filemake = Path.Combine(localAD, id);
            if (File.Exists(filemake) != true)
            {
                File.Create(filemake).Dispose();
                File.WriteAllLines(filemake, content);
            }
        }
        public static void edit(string id, int line, string content)
        {
            string fileed = Path.Combine(localAD, id);
            if (File.Exists(fileed) == true)
            {
                string[] data = File.ReadAllLines(fileed);
                /*
                List<string> lines = new List<string>();
                foreach (string i in data)
                {
                    lines.Add(i);
                }
                */
                data[line] = content;
                File.WriteAllText(fileed, content);
            }
        }
    }
}
