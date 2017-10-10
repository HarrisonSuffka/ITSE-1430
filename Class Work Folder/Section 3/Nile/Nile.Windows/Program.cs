using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;                                                                    
                                                                                               
namespace Nile.Windows                                                                         
{                                                                                              
    static class Program                                                                       
    {                                                                                          
        /// <summary>                                                                          
        /// The main entry point for the application.                                          
        /// </summary>                                                                         
        [STAThread]                                                                            
        static void Main()                                                                     
        {
            //// String Split example
            //var csv = "Field | Field 2 , Field 3 | Field 4";
            //var delimiters = new char[2];
            //delimiters[0] = '|';
            //delimiters[1] = ',';
            //var tokens = csv.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            //var _numberOfElements = tokens.Length;


            Application.EnableVisualStyles();                                                  
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
