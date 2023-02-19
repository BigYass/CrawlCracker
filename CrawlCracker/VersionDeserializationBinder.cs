using System;
using System.Reflection;
using System.Runtime.Serialization;

// Token: 0x020001F9 RID: 505
public sealed class VersionDeserializationBinder : SerializationBinder
{
	// Token: 0x0600127F RID: 4735 RVA: 0x00077058 File Offset: 0x00075258
	public override Type BindToType(string assemblyName, string typeName)
	{
		if (!string.IsNullOrEmpty(assemblyName) && !string.IsNullOrEmpty(typeName))
		{
			assemblyName = Assembly.GetExecutingAssembly().FullName;
			return Type.GetType(string.Format("{0}, {1}", typeName, assemblyName));
		}
		return null;
	}
}
