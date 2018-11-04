using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAutomation.NEmail
{
    class SharkResultsObj
    {

        public class Emailadd
        {
            public string email_addr { get; set; }
            public int email_timestamp { get; set; }
            public string alias { get; set; }
            public string sid_token { get; set; }



        }



        public class CheckEmail
        {


            public class Rootobject
            {
                public List[] list { get; set; }
                public string count { get; set; }
                public string email { get; set; }
                public string alias { get; set; }
                public int ts { get; set; }
                public string sid_token { get; set; }
                public Stats stats { get; set; }
                public Auth auth { get; set; }
            }

            public class Stats
            {
                public string sequence_mail { get; set; }
                public int created_addresses { get; set; }
                public string received_emails { get; set; }
                public string total { get; set; }
                public string total_per_hour { get; set; }
            }

            public class Auth
            {
                public bool success { get; set; }
                public object[] error_codes { get; set; }
            }

            public class List
            {
                public object mail_id { get; set; }
                public string mail_from { get; set; }
                public string mail_subject { get; set; }
                public string mail_excerpt { get; set; }
                public object mail_timestamp { get; set; }
                public object mail_read { get; set; }
                public string mail_date { get; set; }
                public object att { get; set; }
                public string mail_size { get; set; }
                public string reply_to { get; set; }
                public string content_type { get; set; }
                public string mail_recipient { get; set; }
                public int source_id { get; set; }
                public int source_mail_id { get; set; }
                public string mail_body { get; set; }
                public int size { get; set; }
            }

        }


        public class emailbody
            {



                public class Rootobject
                {
                    public string mail_id { get; set; }
                    public string mail_from { get; set; }
                    public string mail_recipient { get; set; }
                    public string mail_subject { get; set; }
                    public string mail_excerpt { get; set; }
                    public string mail_body { get; set; }
                    public string mail_timestamp { get; set; }
                    public string mail_date { get; set; }
                    public string mail_read { get; set; }
                    public string content_type { get; set; }
                    public string source_id { get; set; }
                    public string source_mail_id { get; set; }
                    public string reply_to { get; set; }
                    public string mail_size { get; set; }
                    public string ver { get; set; }
                    public string ref_mid { get; set; }
                    public string sid_token { get; set; }
                    public Auth auth { get; set; }
                }

                public class Auth
                {
                    public bool success { get; set; }
                    public object[] error_codes { get; set; }
                }
            }

    }


    }

