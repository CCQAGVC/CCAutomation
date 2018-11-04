using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;



namespace CCAutomation.NEmail
{
    class gurilamailAPI
    {
        public static string ProdActivationstr = "https://www.casinoclub.com/activateaccount.aspx?code=";
        public static string ProdActivationend = "&language=de" ;
        public static CookieContainer cookies = new CookieContainer();
        public static string WRequest(string ReuestURL)
        {
            HttpWebRequest GetEaddress = (HttpWebRequest)WebRequest.Create(ReuestURL);
            GetEaddress.CookieContainer = cookies;
            HttpWebResponse emailAddress = (HttpWebResponse)GetEaddress.GetResponse();
            Stream datastream = emailAddress.GetResponseStream();
            StreamReader reader = new StreamReader(datastream);
            string responsefromserver = reader.ReadToEnd();
            return responsefromserver;
      
        }


        //Get New email address from Sharklasers. 
        public static string GetNewEmaillAdress()
        {       
            SharkResultsObj.Emailadd newead = new SharkResultsObj.Emailadd();
            Newtonsoft.Json.JsonConvert.PopulateObject( WRequest("http://api.guerrillamail.com/ajax.php?f=get_email_address&ip=127.0.0.1&agent=Mozilla_foo_bar"), newead);
            Console.WriteLine(newead.email_addr);
            return newead.email_addr ;
        }

        //get email boddy of activation email
        public static string GetmailID() 
        
        {

           
            SharkResultsObj.CheckEmail.Rootobject ValidationEmail = new SharkResultsObj.CheckEmail.Rootobject();
            Newtonsoft.Json.JsonConvert.PopulateObject(WRequest("http://api.guerrillamail.com/ajax.php?f=check_email&seq=0"), ValidationEmail);
            Console.WriteLine(ValidationEmail.list[0].mail_id);
            return ValidationEmail.list[0].mail_id.ToString();
        
        }





        //Get the boddy of the verification email
        public static string GetBody() 
        {


            string mailid = GetmailID(); 
            SharkResultsObj.emailbody.Rootobject ValidationEmail = new SharkResultsObj.emailbody.Rootobject();
            Newtonsoft.Json.JsonConvert.PopulateObject(WRequest("http://api.guerrillamail.com/ajax.php?f=fetch_email&email_id=" + mailid), ValidationEmail);
            Console.WriteLine(ValidationEmail.mail_body);
            return ValidationEmail.mail_body;

        }


        //get activation url from email body 
        public static string getbetween(string src, string str, string end) 
        {

            int Start = src.IndexOf(str, 0) + str.Length;
            int End   = src.IndexOf( end , Start ) ;
            string between = src.Substring(Start, End - Start);
            Console.WriteLine(str + between + end);
            return str + between + end;

        }
    }
}
