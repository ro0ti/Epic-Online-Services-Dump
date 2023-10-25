using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200054F RID: 1359
	[Token(Token = "0x200054F")]
	internal struct EntitlementInternal : IGettable<Entitlement>, ISettable<Entitlement>, IDisposable
	{
		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A2F")]
		public Utf8String EntitlementName
		{
			[Token(Token = "0x6002335")]
			[Address(RVA = "0x544E60", Offset = "0x543460", VA = "0x180544E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002336")]
			[Address(RVA = "0x544FF0", Offset = "0x5435F0", VA = "0x180544FF0")]
			set
			{
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A30")]
		public Utf8String EntitlementId
		{
			[Token(Token = "0x6002337")]
			[Address(RVA = "0x544DF0", Offset = "0x5433F0", VA = "0x180544DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002338")]
			[Address(RVA = "0x544F90", Offset = "0x543590", VA = "0x180544F90")]
			set
			{
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A31")]
		public Utf8String CatalogItemId
		{
			[Token(Token = "0x6002339")]
			[Address(RVA = "0x544D80", Offset = "0x543380", VA = "0x180544D80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600233A")]
			[Address(RVA = "0x544F30", Offset = "0x543530", VA = "0x180544F30")]
			set
			{
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000095CC File Offset: 0x000077CC
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A32")]
		public int ServerIndex
		{
			[Token(Token = "0x600233B")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x0600233D RID: 9021 RVA: 0x000095E4 File Offset: 0x000077E4
		// (set) Token: 0x0600233E RID: 9022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A33")]
		public bool Redeemed
		{
			[Token(Token = "0x600233D")]
			[Address(RVA = "0x544ED0", Offset = "0x5434D0", VA = "0x180544ED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600233E")]
			[Address(RVA = "0x545050", Offset = "0x543650", VA = "0x180545050")]
			set
			{
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600233F RID: 9023 RVA: 0x000095FC File Offset: 0x000077FC
		// (set) Token: 0x06002340 RID: 9024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A34")]
		public long EndTimestamp
		{
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x458B00", Offset = "0x457100", VA = "0x180458B00")]
			set
			{
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x544C20", Offset = "0x543220", VA = "0x180544C20", Slot = "5")]
		public void Set(ref Entitlement other)
		{
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x544A20", Offset = "0x543020", VA = "0x180544A20", Slot = "6")]
		public void Set(ref Entitlement? other)
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002343")]
		[Address(RVA = "0x544980", Offset = "0x542F80", VA = "0x180544980", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x5449F0", Offset = "0x542FF0", VA = "0x1805449F0", Slot = "4")]
		public void Get(out Entitlement output)
		{
		}

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_EntitlementName;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_EntitlementId;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_CatalogItemId;

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x20")]
		private int m_ServerIndex;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x24")]
		private int m_Redeemed;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x28")]
		private long m_EndTimestamp;
	}
}
