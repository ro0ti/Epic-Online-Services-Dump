using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	public struct SetAudioOutputSettingsOptions
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000386")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000EED RID: 3821 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000387")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EED")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x00004DB4 File Offset: 0x00002FB4
		// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000388")]
		public float Volume
		{
			[Token(Token = "0x6000EEE")]
			[Address(RVA = "0x4E5440", Offset = "0x4E3A40", VA = "0x1804E5440")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000EEF")]
			[Address(RVA = "0x4E5450", Offset = "0x4E3A50", VA = "0x1804E5450")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
