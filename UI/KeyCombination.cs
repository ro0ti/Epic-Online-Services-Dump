using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[Flags]
	public enum KeyCombination
	{
		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		ModifierShift = 16,
		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		KeyTypeMask = 65535,
		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		ModifierMask = -65536,
		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		Shift = 65536,
		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		Control = 131072,
		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		Alt = 262144,
		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		Meta = 524288,
		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		ValidModifierMask = 983040,
		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		None = 0,
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		Space = 1,
		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		Backspace = 2,
		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		Tab = 3,
		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		Escape = 4,
		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		PageUp = 5,
		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		PageDown = 6,
		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		End = 7,
		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		Home = 8,
		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		Insert = 9,
		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		Delete = 10,
		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		Left = 11,
		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		Up = 12,
		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		Right = 13,
		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		Down = 14,
		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		Key0 = 15,
		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		Key1 = 16,
		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		Key2 = 17,
		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		Key3 = 18,
		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		Key4 = 19,
		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		Key5 = 20,
		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		Key6 = 21,
		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		Key7 = 22,
		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		Key8 = 23,
		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		Key9 = 24,
		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		KeyA = 25,
		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		KeyB = 26,
		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		KeyC = 27,
		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		KeyD = 28,
		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		KeyE = 29,
		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		KeyF = 30,
		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		KeyG = 31,
		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		KeyH = 32,
		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		KeyI = 33,
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		KeyJ = 34,
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		KeyK = 35,
		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		KeyL = 36,
		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		KeyM = 37,
		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		KeyN = 38,
		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		KeyO = 39,
		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		KeyP = 40,
		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		KeyQ = 41,
		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		KeyR = 42,
		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		KeyS = 43,
		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		KeyT = 44,
		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		KeyU = 45,
		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		KeyV = 46,
		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		KeyW = 47,
		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		KeyX = 48,
		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		KeyY = 49,
		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		KeyZ = 50,
		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		Numpad0 = 51,
		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		Numpad1 = 52,
		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		Numpad2 = 53,
		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		Numpad3 = 54,
		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		Numpad4 = 55,
		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		Numpad5 = 56,
		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		Numpad6 = 57,
		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		Numpad7 = 58,
		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		Numpad8 = 59,
		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		Numpad9 = 60,
		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		NumpadAsterisk = 61,
		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		NumpadPlus = 62,
		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		NumpadMinus = 63,
		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		NumpadPeriod = 64,
		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		NumpadDivide = 65,
		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		F1 = 66,
		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		F2 = 67,
		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		F3 = 68,
		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		F4 = 69,
		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		F5 = 70,
		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		F6 = 71,
		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		F7 = 72,
		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		F8 = 73,
		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		F9 = 74,
		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		F10 = 75,
		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		F11 = 76,
		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		F12 = 77,
		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		F13 = 78,
		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		F14 = 79,
		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		F15 = 80,
		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		F16 = 81,
		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		F17 = 82,
		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		F18 = 83,
		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		F19 = 84,
		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		F20 = 85,
		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		F21 = 86,
		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		F22 = 87,
		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		F23 = 88,
		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		F24 = 89,
		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		OemPlus = 90,
		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		OemComma = 91,
		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		OemMinus = 92,
		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		OemPeriod = 93,
		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		Oem1 = 94,
		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		Oem2 = 95,
		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		Oem3 = 96,
		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		Oem4 = 97,
		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		Oem5 = 98,
		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		Oem6 = 99,
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		Oem7 = 100,
		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		Oem8 = 101,
		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		MaxKeyType = 102
	}
}
