using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	public struct UpdateParticipantVolumeOptions
	{
		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F36")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A8")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A9")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000F3A")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x00004E74 File Offset: 0x00003074
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003AA")]
		public float Volume
		{
			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x4AFB30", Offset = "0x4AE130", VA = "0x1804AFB30")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x4AFB80", Offset = "0x4AE180", VA = "0x1804AFB80")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
