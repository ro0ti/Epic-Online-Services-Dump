using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C8 RID: 456
	[Token(Token = "0x20001C8")]
	public struct AudioOutputDeviceInfo
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00004784 File Offset: 0x00002984
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700031E")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x4ACD70", Offset = "0x4AB370", VA = "0x1804ACD70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x4ACD80", Offset = "0x4AB380", VA = "0x1804ACD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700031F")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000320")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x4D70F0", Offset = "0x4D56F0", VA = "0x1804D70F0")]
		internal void Set(ref AudioOutputDeviceInfoInternal other)
		{
		}
	}
}
