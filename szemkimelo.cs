            string json = File.ReadAllText("config.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            jsonObj["estimod"] = "ki";
            string kimenet = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("config.json", kimenet);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\CloudStore\Store\DefaultAccount\Current\default$windows.data.bluelightreduction.bluelightreductionstate\windows.data.bluelightreduction.bluelightreductionstate", true);
            if (szemkimelo == false)
            {
                key.DeleteValue("Data");
                key.Close();
            }
            if (szemkimelo == true)
            {
                byte[] ejszakabe = new byte[]
            {
          0x43,0x42,0x01,0x00,0x0a,0x02,0x01,0x00,0x2a,0x06,0xe0,0xf3,0x8f,0x93,0x06,0x2a,0x2b,0x0e,0x13,0x43,0x42,0x01,0x00,0x10,0x00,0xd0,0x0a,0x02,0xc6,0x14,0xc1,0xcd,0xeb,0xd8,0xaa,0xe2,0x95,0xec,0x01,0x00,0x00,0x00,0x00

            };
                key.SetValue("Data", ejszakabe, RegistryValueKind.Binary);
                key.Close();
                json = File.ReadAllText("config.json");
                jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj["estimod"] = "be";
                kimenet = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", kimenet);
            }
