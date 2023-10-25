using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	internal struct RoomStatisticsUpdatedInfoInternal : ICallbackInfoInternal, IGettable<RoomStatisticsUpdatedInfo>, ISettable<RoomStatisticsUpdatedInfo>, IDisposable
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011B8 RID: 4536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000499")]
		public object ClientData
		{
			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x501B70", Offset = "0x500170", VA = "0x180501B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011B8")]
			[Address(RVA = "0x501D40", Offset = "0x500340", VA = "0x180501D40")]
			set
			{
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x1700049A")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60011B9")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700049B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60011BA")]
			[Address(RVA = "0x501BE0", Offset = "0x5001E0", VA = "0x180501BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011BB")]
			[Address(RVA = "0x501DA0", Offset = "0x5003A0", VA = "0x180501DA0")]
			set
			{
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700049C")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60011BC")]
			[Address(RVA = "0x501C60", Offset = "0x500260", VA = "0x180501C60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011BD")]
			[Address(RVA = "0x501E00", Offset = "0x500400", VA = "0x180501E00")]
			set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700049D")]
		public Utf8String Statistic
		{
			[Token(Token = "0x60011BE")]
			[Address(RVA = "0x501CD0", Offset = "0x5002D0", VA = "0x180501CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011BF")]
			[Address(RVA = "0x501E60", Offset = "0x500460", VA = "0x180501E60")]
			set
			{
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x501A30", Offset = "0x500030", VA = "0x180501A30", Slot = "6")]
		public void Set(ref RoomStatisticsUpdatedInfo other)
		{
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x501880", Offset = "0x4FFE80", VA = "0x180501880", Slot = "7")]
		public void Set(ref RoomStatisticsUpdatedInfo? other)
		{
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x5017F0", Offset = "0x4FFDF0", VA = "0x1805017F0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x501860", Offset = "0x4FFE60", VA = "0x180501860", Slot = "5")]
		public void Get(out RoomStatisticsUpdatedInfo output)
		{
		}

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_RoomName;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_Statistic;
	}
}
