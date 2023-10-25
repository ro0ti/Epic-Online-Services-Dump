using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000222 RID: 546
	[Token(Token = "0x2000222")]
	public struct SetInputDeviceSettingsOptions
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700038C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000EF6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EF7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700038D")]
		public Utf8String RealDeviceId
		{
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00004DCC File Offset: 0x00002FCC
		// (set) Token: 0x06000EFB RID: 3835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700038E")]
		public bool PlatformAEC
		{
			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
