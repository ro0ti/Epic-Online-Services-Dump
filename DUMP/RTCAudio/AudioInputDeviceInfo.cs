using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	public struct AudioInputDeviceInfo
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x000046F4 File Offset: 0x000028F4
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700030F")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x4ACD70", Offset = "0x4AB370", VA = "0x1804ACD70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x4ACD80", Offset = "0x4AB380", VA = "0x1804ACD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000310")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000311")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x4D63E0", Offset = "0x4D49E0", VA = "0x1804D63E0")]
		internal void Set(ref AudioInputDeviceInfoInternal other)
		{
		}
	}
}
