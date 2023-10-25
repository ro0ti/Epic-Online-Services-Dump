using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	public struct UpdateSendingVolumeOptions
	{
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000FDC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FDD")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F2")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x00005114 File Offset: 0x00003314
		// (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F3")]
		public float Volume
		{
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0x4E5440", Offset = "0x4E3A40", VA = "0x1804E5440")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x4E5450", Offset = "0x4E3A50", VA = "0x1804E5450")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
