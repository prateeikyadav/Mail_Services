// Checksum: DD35E79B4D6C3BA7920D59FF8AD5CE03 - Date: 9/14/2023 11:34:59 AM
// 5-May-2023   Pankaj Zanwar : changes done to test all events.. log file is created for testing and should be deleted to avoid disk full
// 8-May-2023   Swapnil Magar : changes done to Credential Block/unauthorized Access.. Msg Body Changes done for ICICI Bank
private static Dictionary<string, string> customDictionary = new Dictionary<string, string>
    {
        // Add your terminal numbers and corresponding email addresses here
		
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
