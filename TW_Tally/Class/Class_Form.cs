using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.IO;
using System.Windows.Forms;


namespace TW_Tally
{
   public class Class_Form
   {
       
     
       string Str = "work";
       public void set(string Text)
       {
           this.Str = Text;
       }
              
        public string get(){
            return Str;
           
        }
        public void getDT()
        {
           MessageBox.Show(DateTime.Now.ToString());
        }
    }
    
       
}
