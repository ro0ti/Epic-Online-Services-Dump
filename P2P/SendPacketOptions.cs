using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	public struct SendPacketOptions
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700063B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60016F4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60016F5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700063C")]
		public ProductUserId RemoteUserId
		{
			[Token(Token = "0x60016F6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60016F7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x000068CC File Offset: 0x00004ACC
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700063D")]
		public SocketId? SocketId
		{
			[Token(Token = "0x60016F8")]
			[Address(RVA = "0x4EC380", Offset = "0x4EA980", VA = "0x1804EC380")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60016F9")]
			[Address(RVA = "0x4EC390", Offset = "0x4EA990", VA = "0x1804EC390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x000068E4 File Offset: 0x00004AE4
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700063E")]
		public byte Channel
		{
			[Token(Token = "0x60016FA")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x60016FB")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000068FC File Offset: 0x00004AFC
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700063F")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x60016FC")]
			[Address(RVA = "0x4A17B0", Offset = "0x49FDB0", VA = "0x1804A17B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x51F950", Offset = "0x51DF50", VA = "0x18051F950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x00006914 File Offset: 0x00004B14
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000640")]
		public bool AllowDelayedDelivery
		{
			[Token(Token = "0x60016FE")]
			[Address(RVA = "0x3D4580", Offset = "0x3D2B80", VA = "0x1803D4580")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60016FF")]
			[Address(RVA = "0x475030", Offset = "0x473630", VA = "0x180475030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x0000692C File Offset: 0x00004B2C
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000641")]
		public PacketReliability Reliability
		{
			[Token(Token = "0x6001700")]
			[Address(RVA = "0x3D4810", Offset = "0x3D2E10", VA = "0x1803D4810")]
			[CompilerGenerated]
			readonly get
			{
				return PacketReliability.UnreliableUnordered;
			}
			[Token(Token = "0x6001701")]
			[Address(RVA = "0x3D48E0", Offset = "0x3D2EE0", VA = "0x1803D48E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00006944 File Offset: 0x00004B44
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000642")]
		public bool DisableAutoAcceptConnection
		{
			[Token(Token = "0x6001702")]
			[Address(RVA = "0x51F940", Offset = "0x51DF40", VA = "0x18051F940")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001703")]
			[Address(RVA = "0x51F970", Offset = "0x51DF70", VA = "0x18051F970")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
