using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Friends
{
	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	internal struct OnBlockedUsersUpdateInfoInternal : ICallbackInfoInternal, IGettable<OnBlockedUsersUpdateInfo>, ISettable<OnBlockedUsersUpdateInfo>, IDisposable
	{
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000963")]
		public object ClientData
		{
			[Token(Token = "0x6002118")]
			[Address(RVA = "0x5494B0", Offset = "0x547AB0", VA = "0x1805494B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002119")]
			[Address(RVA = "0x549680", Offset = "0x547C80", VA = "0x180549680")]
			set
			{
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x00008D5C File Offset: 0x00006F5C
		[Token(Token = "0x17000964")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600211A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000965")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600211B")]
			[Address(RVA = "0x549520", Offset = "0x547B20", VA = "0x180549520")]
			get
			{
				return null;
			}
			[Token(Token = "0x600211C")]
			[Address(RVA = "0x5496E0", Offset = "0x547CE0", VA = "0x1805496E0")]
			set
			{
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000966")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x600211D")]
			[Address(RVA = "0x5495A0", Offset = "0x547BA0", VA = "0x1805495A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600211E")]
			[Address(RVA = "0x549740", Offset = "0x547D40", VA = "0x180549740")]
			set
			{
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x00008D74 File Offset: 0x00006F74
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000967")]
		public bool Blocked
		{
			[Token(Token = "0x600211F")]
			[Address(RVA = "0x549450", Offset = "0x547A50", VA = "0x180549450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002120")]
			[Address(RVA = "0x549620", Offset = "0x547C20", VA = "0x180549620")]
			set
			{
			}
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x549160", Offset = "0x547760", VA = "0x180549160", Slot = "6")]
		public void Set(ref OnBlockedUsersUpdateInfo other)
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x5492A0", Offset = "0x5478A0", VA = "0x1805492A0", Slot = "7")]
		public void Set(ref OnBlockedUsersUpdateInfo? other)
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x5490E0", Offset = "0x5476E0", VA = "0x1805490E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x549140", Offset = "0x547740", VA = "0x180549140", Slot = "5")]
		public void Get(out OnBlockedUsersUpdateInfo output)
		{
		}

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x18")]
		private int m_Blocked;
	}
}
