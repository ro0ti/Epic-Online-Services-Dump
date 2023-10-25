using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public struct SetDisplayPreferenceOptions
	{
		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00002CFC File Offset: 0x00000EFC
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000DF")]
		public NotificationLocation NotificationLocation
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return NotificationLocation.TopLeft;
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
