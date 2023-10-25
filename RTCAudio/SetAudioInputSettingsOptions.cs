using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200021E RID: 542
	[Token(Token = "0x200021E")]
	public struct SetAudioInputSettingsOptions
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037E")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000EDB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037F")]
		public Utf8String DeviceId
		{
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00004D84 File Offset: 0x00002F84
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000380")]
		public float Volume
		{
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x4E5440", Offset = "0x4E3A40", VA = "0x1804E5440")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x4E5450", Offset = "0x4E3A50", VA = "0x1804E5450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00004D9C File Offset: 0x00002F9C
		// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000381")]
		public bool PlatformAEC
		{
			[Token(Token = "0x6000EE1")]
			[Address(RVA = "0x40E220", Offset = "0x40C820", VA = "0x18040E220")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x4C8AC0", Offset = "0x4C70C0", VA = "0x1804C8AC0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
