using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200036D RID: 877
	[Token(Token = "0x200036D")]
	internal struct ModIdentifierInternal : IGettable<ModIdentifier>, ISettable<ModIdentifier>, IDisposable
	{
		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700067C")]
		public Utf8String NamespaceId
		{
			[Token(Token = "0x6001787")]
			[Address(RVA = "0x518780", Offset = "0x516D80", VA = "0x180518780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001788")]
			[Address(RVA = "0x518990", Offset = "0x516F90", VA = "0x180518990")]
			set
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700067D")]
		public Utf8String ItemId
		{
			[Token(Token = "0x6001789")]
			[Address(RVA = "0x518710", Offset = "0x516D10", VA = "0x180518710")]
			get
			{
				return null;
			}
			[Token(Token = "0x600178A")]
			[Address(RVA = "0x518930", Offset = "0x516F30", VA = "0x180518930")]
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700067E")]
		public Utf8String ArtifactId
		{
			[Token(Token = "0x600178B")]
			[Address(RVA = "0x5186A0", Offset = "0x516CA0", VA = "0x1805186A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600178C")]
			[Address(RVA = "0x5188D0", Offset = "0x516ED0", VA = "0x1805188D0")]
			set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700067F")]
		public Utf8String Title
		{
			[Token(Token = "0x600178D")]
			[Address(RVA = "0x5187F0", Offset = "0x516DF0", VA = "0x1805187F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600178E")]
			[Address(RVA = "0x5189F0", Offset = "0x516FF0", VA = "0x1805189F0")]
			set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000680")]
		public Utf8String Version
		{
			[Token(Token = "0x600178F")]
			[Address(RVA = "0x518860", Offset = "0x516E60", VA = "0x180518860")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001790")]
			[Address(RVA = "0x518A50", Offset = "0x517050", VA = "0x180518A50")]
			set
			{
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001791")]
		[Address(RVA = "0x518300", Offset = "0x516900", VA = "0x180518300", Slot = "5")]
		public void Set(ref ModIdentifier other)
		{
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001792")]
		[Address(RVA = "0x518490", Offset = "0x516A90", VA = "0x180518490", Slot = "6")]
		public void Set(ref ModIdentifier? other)
		{
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001793")]
		[Address(RVA = "0x518250", Offset = "0x516850", VA = "0x180518250", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x5182D0", Offset = "0x5168D0", VA = "0x1805182D0", Slot = "4")]
		public void Get(out ModIdentifier output)
		{
		}

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_NamespaceId;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ItemId;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ArtifactId;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_Title;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x28")]
		private IntPtr m_Version;
	}
}
