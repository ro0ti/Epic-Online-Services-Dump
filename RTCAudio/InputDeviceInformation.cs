using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public struct InputDeviceInformation
	{
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00004874 File Offset: 0x00002A74
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000335")]
		public bool DefaultDevice
		{
			[Token(Token = "0x6000D53")]
			[Address(RVA = "0x4ACD70", Offset = "0x4AB370", VA = "0x1804ACD70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D54")]
			[Address(RVA = "0x4ACD80", Offset = "0x4AB380", VA = "0x1804ACD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000336")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000D55")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D56")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000337")]
		public Utf8String DeviceName
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x4D9D30", Offset = "0x4D8330", VA = "0x1804D9D30")]
		internal void Set(ref InputDeviceInformationInternal other)
		{
		}
	}
}
