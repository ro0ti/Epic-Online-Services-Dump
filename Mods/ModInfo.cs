using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	public struct ModInfo
	{
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000681")]
		public ModIdentifier[] Mods
		{
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001796")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000682")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x6001797")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ModEnumerationType.Installed;
			}
			[Token(Token = "0x6001798")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x518F20", Offset = "0x517520", VA = "0x180518F20")]
		internal void Set(ref ModInfoInternal other)
		{
		}
	}
}
