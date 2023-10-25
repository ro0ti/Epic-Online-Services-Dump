using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	public struct SandboxIdItemOwnership
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024CE RID: 9422 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ABA")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x60024CD")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024CE")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060024CF RID: 9423 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024D0 RID: 9424 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ABB")]
		public Utf8String[] OwnedCatalogItemIds
		{
			[Token(Token = "0x60024CF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024D0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x5503C0", Offset = "0x54E9C0", VA = "0x1805503C0")]
		internal void Set(ref SandboxIdItemOwnershipInternal other)
		{
		}
	}
}
