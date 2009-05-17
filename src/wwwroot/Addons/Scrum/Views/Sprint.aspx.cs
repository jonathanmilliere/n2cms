using System;

namespace N2.Templates.Scrum.UI
{
	public partial class Sprint : Web.UI.TemplatePage<Items.ScrumSprint>
	{
		protected override void OnInit(EventArgs e)
		{
			Resources.Register.JQuery(this);
			Resources.Register.StyleSheet(this, "~/Addons/Scrum/Css/Scrum.css");
			Resources.Register.JavaScript(this, "~/Addons/Scrum/Js/jquery.contextmenu.r2.js");
			Resources.Register.JavaScript(this, "~/Addons/Scrum/Js/Scrum.js");
			base.OnInit(e);
		}
	}
}
