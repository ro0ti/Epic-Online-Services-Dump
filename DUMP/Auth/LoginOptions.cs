using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public struct LoginOptions
	{
		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		// (set) Token: 0x060029FB RID: 10747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C3F")]
		public Credentials? Credentials
		{
			[Token(Token = "0x60029FA")]
			[Address(RVA = "0x55EE60", Offset = "0x55D460", VA = "0x18055EE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60029FB")]
			[Address(RVA = "0x55EE80", Offset = "0x55D480", VA = "0x18055EE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x0000A8BC File Offset: 0x00008ABC
		// (set) Token: 0x060029FD RID: 10749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C40")]
		public AuthScopeFlags ScopeFlags
		{
			[Token(Token = "0x60029FC")]
			[Address(RVA = "0x3D2E80", Offset = "0x3D1480", VA = "0x1803D2E80")]
			[CompilerGenerated]
			readonly get
			{
				return AuthScopeFlags.NoFlags;
			}
			[Token(Token = "0x60029FD")]
			[Address(RVA = "0x3D2EB0", Offset = "0x3D14B0", VA = "0x1803D2EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		// (set) Token: 0x060029FF RID: 10751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C41")]
		public LoginFlags LoginFlags
		{
			[Token(Token = "0x60029FE")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return LoginFlags.None;
			}
			[Token(Token = "0x60029FF")]
			[Address(RVA = "0x55EEB0", Offset = "0x55D4B0", VA = "0x18055EEB0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
