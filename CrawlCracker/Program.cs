using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;

class CrawlCracker {
	private static Dictionary<string, object> m_data = new Dictionary<string, object>();
	private static int num;

	private static void loadFile()
    {
		Console.WriteLine("Trying to open : " + Data.pathSave);

		if (!File.Exists(Data.pathSave))
			Console.WriteLine(Data.pathSave + "n'existe pas");

		Stream stream = File.Open(Data.pathSave, FileMode.Open);

		if (stream.Length <= 0L)
			Console.WriteLine("Fichier non existant!");

		Stream stream2 = null;

		stream2 = new CryptoStream(stream, new DESCryptoServiceProvider
		{
			Key = Data.NOTHING_TO_SEE_HERE,
			IV = Data.JUST_A_REGULAR_VARIABLE
		}.CreateDecryptor(), CryptoStreamMode.Read);
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Binder = new VersionDeserializationBinder();
		num = (int)binaryFormatter.Deserialize(stream);

		if (num < 0)
			Console.WriteLine("Version non reconnu : " + num);

		if (num == 0)
		{
			m_data = (binaryFormatter.Deserialize(stream2) as Dictionary<string, object>);
		}
		else
		{
			List<string> list = binaryFormatter.Deserialize(stream2) as List<string>;
			List<object> list2 = binaryFormatter.Deserialize(stream2) as List<object>;
			for (int i = 0; i < list.Count; i++)
			{
				m_data[list[i]] = list2[i];
			}
		}


		stream.Close();
		stream2.Close();
	}
	private static void saveFile()
    {
		Stream stream = File.Open(Data.pathSave, FileMode.Create);
		Stream stream2 = new CryptoStream(stream, new DESCryptoServiceProvider
		{
			Key = Data.NOTHING_TO_SEE_HERE,
			IV = Data.JUST_A_REGULAR_VARIABLE
		}.CreateEncryptor(), CryptoStreamMode.Write);

		BinaryFormatter binaryFormatter = new BinaryFormatter();
		binaryFormatter.Binder = new VersionDeserializationBinder();
		binaryFormatter.Serialize(stream, 1);
		List<string> list = new List<string>(m_data.Count);
		List<object> list2 = new List<object>(m_data.Count);
		foreach (KeyValuePair<string, object> keyValuePair in m_data)
		{
			list.Add(keyValuePair.Key);
			list2.Add(keyValuePair.Value);
		}
		binaryFormatter.Serialize(stream2, list);
		binaryFormatter.Serialize(stream2, list2);

		if(stream2 != null)
			stream2.Close();
		
		if(stream != null)
			stream.Close();

	}
	private static void backUpFile()
    {
		String bakPath = Data.pathSave + ".bak";

		if(!File.Exists(bakPath))
			File.Copy(Data.pathSave, Data.pathSave + ".bak");
    }
	private static void doStuff()
    {
		Console.WriteLine("Save Version : " + num);

		foreach (String key in m_data.Keys)
			Console.WriteLine(key + " : " + m_data[key]);


		m_data["Ach.GoldSpentAG"] = 1000;
		m_data["Ach.GoldSpentBG"] = 5000;
		m_data["Ach.GoldSpentCG"] = 10000;

		m_data["Ach.HumanityAHG"] = 10;
		m_data["Ach.HumanityBHG"] = 10;
		m_data["Ach.HumanityCHG"] = 10;






		for (int i = 0; i < 61; i++)
		{
			m_data["lib." + i + ".f"] = 1;
			m_data["lib." + i + ".n"] = 0;
			m_data["lib." + i + ".hs"] = 99;
			m_data["lib." + i + ".ls"] = 99;
		}

		for(int i = 61; i < 228; i++)
        {
			m_data["lib." + i + ".f"] = 1;
			m_data["lib." + i + ".n"] = 0;
			
		}

		m_data["prof13.name"] = "YAS";
		m_data["prof13.s.GamesStarted"] = 999;
		m_data["prof13.s.GamesCompleted"] = 999;
		m_data["prof13.s.BossAttempts"] = 999;
		m_data["prof13.s.DamageHero"] = 999999f;
		m_data["prof13.s.DamageMonster"] = 999999f;
		m_data["prof13.s.HitsHero"] = 999;
		m_data["prof13.s.HitsMonster"] = 999;
		m_data["prof13.s.Level"] = 99;
		m_data["prof13.s.GoldSpent"] = 9999;
		m_data["prof13.s.GoldEarned"] = 9999;
		m_data["prof13.sl.GamesStarted"] = 999;
		m_data["prof13.sl.GamesCompleted"] = 999;
		m_data["prof13.sl.BossAttempts"] = 999;
		m_data["prof13.sl.KillsBoss"] = 99;
		m_data["prof13.sl.KillsHero"] = 999;
		m_data["prof13.sl.KillsMonster"] = 999;
		m_data["prof13.sl.DamageHero"] = 9999999f;
		m_data["prof13.sl.DamageMonster"] = 999999f;
		m_data["prof13.sl.HitsHero"] = 999999;
		m_data["prof13.sl.HitsMonster"] = 999999;
		m_data["prof13.sl.Level"] = 999;
		m_data["prof13.sl.HeroVitality"] = 999;
		m_data["prof13.sl.HeroStrength"] = 999;
		m_data["prof13.sl.HeroDexterity"] = 999;
		m_data["prof13.sl.HeroWisdom"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.VitaeEarned"] = 999999;
		m_data["prof13.sl.VitaeSpent"] = 999999;
		m_data["prof13.sl.GoldEarned"] = 999999;
		m_data["prof13.sl.GoldSpent"] = 999999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;
		m_data["prof13.sl.HeroCharisma"] = 999;







		Console.WriteLine("Changement du dictionnaire de sauvegarde");

		foreach (String key in m_data.Keys)
			Console.WriteLine(key + " : " + m_data[key]);
	}
	
	static void Main(string[] args)
	{
		//backUpFile();

		loadFile();

		doStuff();

		saveFile();

		Console.Write("Le programme a fini correctement!");

	}



}