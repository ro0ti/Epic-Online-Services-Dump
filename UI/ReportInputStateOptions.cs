using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public struct ReportInputStateOptions
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00002BDC File Offset: 0x00000DDC
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C7")]
		public InputStateButtonFlags ButtonDownFlags
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return InputStateButtonFlags.None;
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00002BF4 File Offset: 0x00000DF4
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C8")]
		public bool AcceptIsFaceButtonRight
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x4AFB10", Offset = "0x4AE110", VA = "0x1804AFB10")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x4AFB60", Offset = "0x4AE160", VA = "0x1804AFB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00002C0C File Offset: 0x00000E0C
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000C9")]
		public bool MouseButtonDown
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x4AFB40", Offset = "0x4AE140", VA = "0x1804AFB40")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x4AFB90", Offset = "0x4AE190", VA = "0x1804AFB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00002C24 File Offset: 0x00000E24
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CA")]
		public uint MousePosX
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00002C3C File Offset: 0x00000E3C
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CB")]
		public uint MousePosY
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00002C54 File Offset: 0x00000E54
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CC")]
		public uint GamepadIndex
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00002C6C File Offset: 0x00000E6C
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CD")]
		public float LeftStickX
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x4AFB20", Offset = "0x4AE120", VA = "0x1804AFB20")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x4AFB70", Offset = "0x4AE170", VA = "0x1804AFB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CE")]
		public float LeftStickY
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x4AFB30", Offset = "0x4AE130", VA = "0x1804AFB30")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x4AFB80", Offset = "0x4AE180", VA = "0x1804AFB80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00002C9C File Offset: 0x00000E9C
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CF")]
		public float RightStickX
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x4AFB50", Offset = "0x4AE150", VA = "0x1804AFB50")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x4AFA60", Offset = "0x4AE060", VA = "0x1804AFA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00002CB4 File Offset: 0x00000EB4
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D0")]
		public float RightStickY
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x3E4000", Offset = "0x3E2600", VA = "0x1803E4000")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x3E4040", Offset = "0x3E2640", VA = "0x1803E4040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D1")]
		public float LeftTrigger
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x3E3FF0", Offset = "0x3E25F0", VA = "0x1803E3FF0")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x3E4030", Offset = "0x3E2630", VA = "0x1803E4030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D2")]
		public float RightTrigger
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x3E3FE0", Offset = "0x3E25E0", VA = "0x1803E3FE0")]
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x3E4020", Offset = "0x3E2620", VA = "0x1803E4020")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
