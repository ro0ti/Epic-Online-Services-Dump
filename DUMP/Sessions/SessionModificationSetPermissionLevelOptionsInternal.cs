using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	internal struct SessionModificationSetPermissionLevelOptionsInternal : ISettable<SessionModificationSetPermissionLevelOptions>, IDisposable
	{
		// Token: 0x1700028A RID: 650
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700028A")]
		public OnlineSessionPermissionLevel PermissionLevel
		{
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SessionModificationSetPermissionLevelOptions other)
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x4CB6A0", Offset = "0x4C9CA0", VA = "0x1804CB6A0", Slot = "5")]
		public void Set(ref SessionModificationSetPermissionLevelOptions? other)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x4")]
		private OnlineSessionPermissionLevel m_PermissionLevel;
	}
}
