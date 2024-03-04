using SimaiParserWithAntlr;

namespace ParserTest.ChartParserTest;

public class ChartParserTest
{
    // TODO: more testcases
    [Fact]
    public void DebugTest()
    {
        var parser = ChartParser.GenerateFromText(@"
(180){1}1,2b,3bx,4x,
(170){4}
<HS*5>
1h,2bh,3bxh,4hxb,5hhbbxx,6xxhb,
(160.5)
{16}1h[8:1],2bh[#0.5],3bxh[120#8:1],4hxb[2.5##8:1],5hhbbxx[2.5##1.5],6xxhb[2.5##120#8:1],
A1,B2f,<HS*2>Cf,C1,C2f,D3ff,E4,
(125.5)
{32}
Ch,Cfh,Chf,C1fh,C2h,Chfhh,
Ch[8:1],Cfh[#0.5],Chf[120#8:1],C1fh[2.5##8:1],C2h[2.5##1.5],Chfhh[2.5##120#8:1],
|| comment test
|| Ch[8:1],Cfh[#0.5],Chf[120#8:1],C1fh[2.5##8:1],C2h[2.5##1.5],Chfhh[2.5##120#8:1],

1-5[8:1],2-5-1[#0.5],3bx-5[120#8:1],4xbx-5-1[2.5##8:1],5-2-5b[2.5##1.5],6-2-6[2.5##120#8:1]b,
1b-5b[8:1],1xb-5[8:1]-1[8:1]b, || comment test 2 1,2,1-5[8:1]
1-5[8:1]*-6[8:1],1bx-5b[8:1]*-6[8:1]b,1xb-5[8:1]b*-6b[8:1],1-5-1b[8:1]*-6-1[8:1]b,1-5[8:1]*-6[2.5##120#8:1],
(120)(130){4}{8}

1/2,1/3/5,1`2,1/2`3/4,1`2/3`4,
");
        parser = ChartParser.GenerateFromText(@"
(120){1},
{384}1`2`3`4,1h[8:1]`2h[8:1]`3h[8:1]`4h[8:1],
");
    }
}
