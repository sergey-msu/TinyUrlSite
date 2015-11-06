//WARNING: This code was auto generated by template compiler, do not modify by hand!
//Generated on 05.11.2015 0:18:43 by NFX.Templatization.TextCSTemplateCompiler at PC

using System; 
using System.Text; 
using System.Linq; 
using System.Collections.Generic; 

namespace TinyUrlSite.Pages 
{

 ///<summary>
 /// Index page
 ///</summary>
 public  class Index : TinyUrlSite.Pages.Master
 {


    public string InitialUrl { get; set; }
    public string Message { get; set; }
    public bool IsHyperlink { get; set; }


     protected override void DoRender()
     {
       base.DoRender();
        Target.Write( Index._66_S_LITERAL_0 );

     }
    protected override void  renderBody()
    {
        Target.Write( Index._66_S_LITERAL_1 );
        Target.Write(Target.Encode( InitialUrl ));
        Target.Write( Index._66_S_LITERAL_2 );
      if(IsHyperlink){
        Target.Write( Index._66_S_LITERAL_3 );
        Target.Write(Target.Encode( Message ));
        Target.Write( Index._66_S_LITERAL_4 );
        Target.Write(Target.Encode( Message ));
        Target.Write( Index._66_S_LITERAL_5 );
      } else {
        Target.Write( Index._66_S_LITERAL_6 );
        Target.Write(Target.Encode( Message ));
        Target.Write( Index._66_S_LITERAL_7 );
      }
        Target.Write( Index._66_S_LITERAL_8 );

    }


     #region Literal blocks content
        private const string _66_S_LITERAL_0 = @"

"; 
        private const string _66_S_LITERAL_1 = @"

<style>
   #divRoot {
       width: 480px; 
       height: 25px; 
       position: absolute; 
       top: -130px; 
       bottom: 0; 
       left: 0; 
       right: 0; 
       margin: auto;
   }

   #divTitle {
       font-size: 18px; 
       font-family: 'Verdana'; 
   }

   #inputUrl {
       width: 350px;
       height: 25px; 
       font-size: 18px; 
       font-family: 'Verdana'; 
   }

   #inputBtn {
       width: auto;
       height: 30px; 
   }

   .message {
      font-size: 14px; 
      font-family: 'Verdana';
      text-align: center; 
      display: block; 
      margin: 10px auto;
   }

   .block {
       display: inline-block;
   }
</style>

<div id=""divRoot"">
    <form action=""/Shorten"" method=""post"">
        <table>
            <tr>
                <td id=""divTitle"" class=""block"">URL: </td>
                <td class=""block"">
                    <input id=""inputUrl"" type=""text"" name=""initialUrl"" value="""; 
        private const string _66_S_LITERAL_2 = @""">
                </td>
                <td class=""block"">
                    <button id=""inputBtn"" type=""submit"">Shorten</button>
                </td>
            </tr>
        </table>
    </form>
    "; 
        private const string _66_S_LITERAL_3 = @"
    <div class=""message"">
        <a href="""; 
        private const string _66_S_LITERAL_4 = @""">"; 
        private const string _66_S_LITERAL_5 = @"</a>
    </div>
    "; 
        private const string _66_S_LITERAL_6 = @"
    <div class=""message"">"; 
        private const string _66_S_LITERAL_7 = @"</div>
    "; 
        private const string _66_S_LITERAL_8 = @" 
</div>"; 
     #endregion

 }//class
}//namespace
