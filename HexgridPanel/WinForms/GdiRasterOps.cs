﻿#region The MIT License - Copyright (C) 2012-2019 Pieter Geerkens
/////////////////////////////////////////////////////////////////////////////////////////
//                PG Software Solutions - Hex-Grid Utilities
/////////////////////////////////////////////////////////////////////////////////////////
// The MIT License:
// ----------------
// 
// Copyright (c) 2012-2019 Pieter Geerkens (email: pgeerkens@users.noreply.github.com)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, 
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to 
// permit persons to whom the Software is furnished to do so, subject to the following 
// conditions:
//     The above copyright notice and this permission notice shall be 
//     included in all copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//     EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//     OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
//     NON-INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
//     HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
//     WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
//     FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
//     OTHER DEALINGS IN THE SOFTWARE.
/////////////////////////////////////////////////////////////////////////////////////////
#endregion
using System;

namespace PGNapoleonics.HexgridPanel.WinForms {
  internal enum GdiRasterOps {
    SrcCopy                 = 0x00CC0020, /* dest = source                   */ 
    SrcPaint                = 0x00EE0086, /* dest = source OR dest           */
    SrcAnd                  = 0x008800C6, /* dest = source AND dest          */
    SrcInvert               = 0x00660046, /* dest = source XOR dest          */
    SrcErase                = 0x00440328, /* dest = source AND (NOT dest )   */ 
    NotSrcCopy              = 0x00330008, /* dest = (NOT source)             */
    NotSrcErase             = 0x001100A6, /* dest = (NOT src) AND (NOT dest) */ 
    MergeCopy               = 0x00C000CA, /* dest = (source AND pattern)     */ 
    MergePaint              = 0x00BB0226, /* dest = (NOT source) OR dest     */
    PatCopy                 = 0x00F00021, /* dest = pattern                  */ 
    PatPaint                = 0x00FB0A09, /* dest = DPSnoo                   */
    PatInvert               = 0x005A0049, /* dest = pattern XOR dest         */
    DstInvert               = 0x00550009, /* dest = (NOT dest)               */
    Blackness               = 0x00000042, /* dest = BLACK                    */ 
    Whiteness               = 0x00FF0062  /* dest = WHITE                    */
//    public const int CaptureBlt              = 0x40000000; /* Include layered windows */ 
  }
}
