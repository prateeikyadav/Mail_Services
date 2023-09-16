// Checksum: DD35E79B4D6C3BA7920D59FF8AD5CE03 - Date: 9/14/2023 11:34:59 AM
// 5-May-2023   Pankaj Zanwar : changes done to test all events.. log file is created for testing and should be deleted to avoid disk full
// 8-May-2023   Swapnil Magar : changes done to Credential Block/unauthorized Access.. Msg Body Changes done for ICICI Bank
private static Dictionary<string, string> customDictionary = new Dictionary<string, string>
    {
        // Add your terminal numbers and corresponding email addresses here
{"AGRA","saurabh.be@icicibank.com,gajendra.kumar@icicibank.com,kaushal.kulshrestha@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"AHMEDABAD","hasmukh.patel@icicibank.com,sunil.goplani@icicibank.com,dhananjay.trivedi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"AURANGABAD","kiran.kathar@icicibank.com,kishor.ghodke@icicibank.com,priya.nair@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"BALLARI","veesam.naresh@icicibank.com,sangamesh.tiparaddi@icicibank.com,pratush.mittagunta@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"BANDRA","prashant.anchan@icicibank.com,vicky.pathade@icicibank.com,dhiraj.todi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"BENGALURU","devendran.kp@icicibank.com,george.christopher@icicibank.com,pratush.mittagunta@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"BHOPAL","joshi.harish@icicibank.com,parihar.kamlakar@icicibank.com,kishor.modi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"BHUBANESWAR","saket.ravi@icicibank.com,niranjan.behera@icicibank.com,kalpesh.taank@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"BIKANER","mitesh.dosi@icicibank.com,mahendr.singh@icicibank.com,satyam.prasad@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"CHENNAI","s.ramakrishnan@icicibank.com,shanmugam.d@icicibank.com,suresh.jampani@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"COIMBATORE","novil.francis@icicibank.com,ganesh.or@icicibank.com,suresh.jampani@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"DIBRUGARH","dhrubajyoti.goswami@icicibank.com,vikash.si@icicibank.com,maneesh.pandey@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"DOMBIVALI","karthik.rao@icicibank.com,chetan.padekar@icicibank.com,dhiraj.todi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"GUWAHATI","rakesh.b@icicibank.com,sangit.bharali@icicibank.com,maneesh.pandey@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"HAUZKHAS","raj.singh@icicibank.com,ajoy.kumar@icicibank.com,tarunesh.sharan@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"HYDERABAD","bapaiah.koppula@icicibank.com,md.naimuddin@icicibank.com,venu.gadeela@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"INDORE","sarika.agrawal@icicibank.com,amit.verma@icicibank.com,kishor.modi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"JABALPUR","ashvin.vithalpara@icicibank.com,mishra.lokesh@icicibank.com,kishor.modi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"JAIPUR","tilak.khare@icicibank.com,pradeep.jain@icicibank.com,satyam.prasad@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"JALANDHAR","manoj.mangla@icicibank.com,nikita.ahuja@icicibank.com,vishal.shar@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"JODHPUR","ankit.munot@icicibank.com,mohan.soni@icicibank.com,satyam.prasad@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"KOCHI","vinod.mohan@icicibank.com,sarathkumar.panampully@icicibank.com,ajit.menon@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"KOLKATA","noorus.sabah@icicibank.com,abhik.ghosh@icicibank.com,maneesh.pandey@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"KOTA","raviprakash.gupta@icicibank.com,rakesh.ranka@icicibank.com,satyam.prasad@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"LUCKNOW","sandeep.srivastava@icicibank.com,shailesh.gangwar@icicibank.com,rahul.kannojia@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"MADURAI","karthickkumar.tkn@icicibank.com,ramanan.roopchandar@icicibank.com,suresh.jampani@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"MANGALORE","sudeep.ravindran@icicibank.com,kananjar.deepakkumar@icicibank.com,pratush.mittagunta@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"MEERUT","abhish.s@icicibank.com,kushagra.dixit@icicibank.com,tarunesh.sharan@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"MOHALI","jagdeep.singh@icicibank.com,baljeetkumar.dhiman@icicibank.com,vishal.shar@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"NAGPUR","kumarmanish.ranjan@icicibank.com,kapil.joshi@icicibank.com,priya.nair@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"PANAJI","anupama.balakrishnan@icicibank.com,sarvesh.balapure@icicibank.com,dhiraj.todi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"PANIPAT","vinod.gehlot@icicibank.com,sharma.maneesh@icicibank.com,vishal.shar@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"PATNA","ashwini.choudhary@icicibank.com,dinbandhu.kumar@icicibank.com,pankaj.karn@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"PUNE","naik.vikrant@icicibank.com,shinde.man@icicibank.com,priya.nair@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"PUSHPANJALI","vijay.anan@icicibank.com,abhijit.pal@icicibank.com,tarunesh.sharan@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"RAIPUR","santosh.senapaty@icicibank.com,sunaina.mahant@icicibank.com,kalpesh.taank@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"RAJKOT","keyur.s@icicibank.com,jaydip.dave@icicibank.com,dhananjay.trivedi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"RANCHI","malaya.kumar@icicibank.com,vikash.chandra@icicibank.com,pankaj.karn@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"SANGLI","shree.kharade@icicibank.com,mandar.phutane@icicibank.com,priya.nair@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"SILIGURI","kumar.pra@icicibank.com,atanu.dutta@icicibank.com,maneesh.pandey@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"SURAT","manish.rajput@icicibank.com,chirag.dave@icicibank.com,dhananjay.trivedi@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"TRICHY","sudhan.coby@icicibank.com,senthil.s@icicibank.com,suresh.jampani@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"UDAIPUR","milan.mehta@icicibank.com,pradeep.srivastava@icicibank.com,satyam.prasad@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"VARANASI","jay.g@icicibank.com,shailendra.tiwari@icicibank.com,rahul.kannojia@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"VIJAYWADA","satyaprakash.konduru@icicibank.com,akula.v@icicibank.com,venu.gadeela@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"},
{"VISAKHAPATNAM","sarat.chandra@icicibank.com,akella.rao@icicibank.com,venu.gadeela@icicibank.com,swagat.patil@icicibank.com,rachana.patne@icicibank.com,robin.miranda@icicibank.com ,alertkiam@gmail.com,sm@kiam.in"}


		
		// Add more entries as needed
    };

public override void DoAlarmAction(AlarmData alarm)
        {
            OpenApi.System.Grammar.ITransaction transaction = OpenApi.System.InProc.Factory.CreateTransaction();
            transaction.Authorize.Login();
            try
            {
                transaction.Context.Mailing.SendMail(new MailMessage(
                        "biometricalerts@icicibank.com", // TODO specify a correct from email-address
                        customDictionary[GetDeviceDisplaystringOrNull(alarm).Split(' ')[4]], //TODO 
                        GetSubject(alarm),
                        GetBodyText(alarm)
                    )
                );
            }
            finally
            {
                transaction.Authorize.Logout();
            }
			
        }

        private static void SendMail1(MailAddress from, MailAddressCollection to, string subject, string body)
        {
            // Senden der Mails mit den Parametern aus der Funktion "CreateSmtpClient()"
            using (var client = CreateSmtpClient1())
            {
                using (var message = new MailMessage()
                {
                    From = from,
                    Subject = subject,
                    Body = body,
                })
                {
                    message.To.Add(to.ToString());
                    client.Send(message);
                }
            }
        }
        
        private static SmtpClient CreateSmtpClient1()
        {
            // Parameter für den SMTP-Server aus dem Konfigurator
            var settings = new CustomAppSettings();
            var host = settings.SmtpServer;
            var port = settings.SmtpServerPort.Value;
            var client = new SmtpClient(host, port);
            // Passwort wird entschlüsselt "DeCrypt"
            client.Credentials = new NetworkCredential(settings.SmtpUser, Foundation.Tools.Crypter.SymmetricCrypter.SymmetricCrypter.DeCrypt(settings.SmtpPassword));
            client.EnableSsl = true;
            return client;
        }

        private static string GetSubject(AlarmData alarm)
        {
			//String.Format("ACCESS SYSTEM: {1}", alarm.Number, alarm.Name);
             return String.Format("Access Control Alarm: {0}:{1}", alarm.Number, alarm.Name);
        }

        private string GetBodyText(AlarmData alarm)
        {

            // Für den Debugger try auskommnentieren
            // System.Diagnostics.Debugger.Launch();
            // System.Diagnostics.Debugger.Break();

            // Parameter für den Alarm werden aufbereitet
            var eventDisplaystring = GetEventDisplaystring(alarm);
            var terminalDisplaystring = GetDeviceDisplaystringOrNull(alarm);
            var location = terminalDisplaystring.Split(' ')[4];
            var personName = "--------------";
            var perNr = "--------------";
            var auswNr = "--------------";
            var time = DateTime.Today;
            var bodyText = new StringBuilder();

            // Ausgabe in Datei
            string occur_data = alarm.CreationTime.ToLocalTime().ToString(@"dddd  dd-MMM-yyyy HH:mm:ss");

            // Prüfung ob Personendaten vorhanden sind
            if (alarm.Event.PersonRef != null)
            {
               
                // Get Employee Details
                personName = alarm.Event.PersonRef.DisplayString;
                var alarmGuid = alarm.Event.PersonRef.Guid;
                var checkPers = Api.Transaction.Data.Employees[alarmGuid];
                perNr = checkPers.stpersnr;
                time = alarm.Event.CreationTime;
                var archive = Api.Transaction.Data.IF_accessarchives.Select(BOP.IF_accessarchive.zuutcdate == time && BOP.IF_accessarchive.zussnr == checkPers.stssnr);
                if (archive != null)
                    auswNr = archive[0].zucrnr;
            }   
            string starttxt = "Dear Team, \n\r Following email is generated from Access control Application \n\r ";
			string starttxt1 = "\n\rThanks & Regards, \n\r KIAM INTL PVT LTD \n\r ";
            // Formatierung der Daten    
            bodyText.AppendFormat(

                   starttxt + "Occurance Date:\t {0} \r\nEvent String:\t '{1}' \r\nTerminal:\t '{2}' \r\nPerson Name:\t {3}\r\nPersonalNr.:\t {4}\r\nOtherDetail:\t {5}" + starttxt1,
                   occur_data,
                   //alarm.CreationTime.ToString(@"dddd  dd.MM.yyyy HH:mm:ss"),
                   
                   eventDisplaystring,
                   terminalDisplaystring,
                   personName,
                   perNr,
                   auswNr
                   );   
            
			occur_data = occur_data +"\nTEST\r\n" + bodyText.ToString() +"\n\r"+ alarm.ToString() + "\n\r alarm.Event.ToString" + alarm.Event.ToString();
			
			if (alarm.Event.PersonRef != null)
			{
				var pName = alarm.Event.PersonRef.DisplayString;
                var alarmGuid1 = alarm.Event.PersonRef.Guid;
                var checkPers1 = Api.Transaction.Data.Employees[alarmGuid1];
                var perNr1 = checkPers1.stpersnr;
				var sttgr = checkPers1.sttgr;
				var stausdat = checkPers1.stausdat.ToString();
				var steindat = checkPers1.steindat.ToString();
				
				occur_data = occur_data +"\n\r alarm.Event.PersonRef " + "\n\r pName " + pName.ToString() + "\n\r alarmGuid1 " + alarmGuid1.ToString() + "\n\r checkPers1 " + checkPers1.ToString() + "\n\r perNr1 " +perNr1.ToString()
				+"\n\r stausdat " + stausdat.ToString() + "\n\r steindat"+ steindat.ToString();
			}
			var deviceRef1 = alarm.Event.DeviceRef;
			occur_data = occur_data + "\n\r deviceRef1 " +deviceRef1.ToString();
				 
            WriteToLogFile(@"C:\IF6040\IF6040 (64Bit)\ApplicationServer\logs\", Convert.ToString(occur_data ), ".log");

            
            
            
            return bodyText.ToString();

           
        }

        private static string GetEventDisplaystring(AlarmData alarm)
        {
            var deviceRef = alarm.Event.DeviceRef;
            return deviceRef == null ? null : String.Format("{0}:{1}", alarm.Event.Number, alarm.Event.Name);
        }

        private static string GetDeviceDisplaystringOrNull(AlarmData alarm)
        {
            var deviceRef = alarm.Event.DeviceRef;
            return deviceRef == null ? null : deviceRef.DisplayString;
        }

        private void WriteToLogFile(string location, string record, string extension)
        {
            string filename = string.Format("_Info{0:yyyyMMdd}" + extension, DateTime.Today);
            //string path = GetParamAsString(location);
            string path = location;
            if (!path.EndsWith("\\"))
                path += "\\";
            filename = path + filename;

            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                var sw = File.AppendText(filename);
                sw.WriteLine(record);
                sw.Close();
            }
            catch (Exception ex)
            {
                Logfile.Error(ex.Message);
            }
        }
