using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	public struct OutputDeviceInformation
	{
		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00004AE4 File Offset: 0x00002CE4
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000361")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x4ACD70", Offset = "0x4AB370", VA = "0x1804ACD70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x4ACD80", Offset = "0x4AB380", VA = "0x1804ACD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000362")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000363")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x4DDCD0", Offset = "0x4DC2D0", VA = "0x1804DDCD0")]
		internal void Set(ref OutputDeviceInformationInternal other)
		{
		}
	}
}
