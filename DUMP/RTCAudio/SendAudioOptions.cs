using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	public struct SendAudioOptions
	{
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000378")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000ECF")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000379")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000ED1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ED2")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00004D6C File Offset: 0x00002F6C
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700037A")]
		public AudioBuffer? Buffer
		{
			[Token(Token = "0x6000ED3")]
			[Address(RVA = "0x4E4FE0", Offset = "0x4E35E0", VA = "0x1804E4FE0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000ED4")]
			[Address(RVA = "0x4E5000", Offset = "0x4E3600", VA = "0x1804E5000")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
