using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000594 RID: 1428
	[Token(Token = "0x2000594")]
	internal struct SandboxIdItemOwnershipInternal : IGettable<SandboxIdItemOwnership>, ISettable<SandboxIdItemOwnership>, IDisposable
	{
		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ABC")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x60024D2")]
			[Address(RVA = "0x550270", Offset = "0x54E870", VA = "0x180550270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D3")]
			[Address(RVA = "0x550360", Offset = "0x54E960", VA = "0x180550360")]
			set
			{
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ABD")]
		public Utf8String[] OwnedCatalogItemIds
		{
			[Token(Token = "0x60024D4")]
			[Address(RVA = "0x5501E0", Offset = "0x54E7E0", VA = "0x1805501E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024D5")]
			[Address(RVA = "0x5502E0", Offset = "0x54E8E0", VA = "0x1805502E0")]
			set
			{
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x550160", Offset = "0x54E760", VA = "0x180550160", Slot = "5")]
		public void Set(ref SandboxIdItemOwnership other)
		{
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x550090", Offset = "0x54E690", VA = "0x180550090", Slot = "6")]
		public void Set(ref SandboxIdItemOwnership? other)
		{
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x550010", Offset = "0x54E610", VA = "0x180550010", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x550070", Offset = "0x54E670", VA = "0x180550070", Slot = "4")]
		public void Get(out SandboxIdItemOwnership output)
		{
		}

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_SandboxId;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_OwnedCatalogItemIds;

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0x10")]
		private uint m_OwnedCatalogItemIdsCount;
	}
}
