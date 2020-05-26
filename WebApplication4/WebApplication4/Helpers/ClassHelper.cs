using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Helpers
{
    public static class ClassHelper
    {
        public static MvcHtmlString DisplayQuestRoom(this HtmlHelper html, QuestRoom room)
        {
            TagBuilder tagUl = new TagBuilder("ul");
            tagUl.AddCssClass("quests-list");
            TagBuilder tagLi = new TagBuilder("li");
            tagLi.AddCssClass("quest-item");
            TagBuilder tagDiv = new TagBuilder("div");
            tagDiv.AddCssClass("jumbotron");
            TagBuilder tagH1 = new TagBuilder("h1");
            tagH1.AddCssClass("display-4");
            tagH1.SetInnerText(room.Name);
            TagBuilder tagP = new TagBuilder("p");
            tagP.AddCssClass("lead");
            tagP.SetInnerText(room.Description);
            TagBuilder tagHr = new TagBuilder("hr");
            tagHr.AddCssClass("my-4");
            TagBuilder tagP2 = new TagBuilder("p");
            tagP2.SetInnerText("Duration: " +room.Description);

            tagDiv.InnerHtml += tagH1.ToString();
            tagDiv.InnerHtml += tagP.ToString();
            tagDiv.InnerHtml += tagHr.ToString();
            tagDiv.InnerHtml += tagP2.ToString();

            tagLi.InnerHtml += tagDiv.ToString();

            tagUl.InnerHtml += tagLi.ToString();


    //     < ul class="quests-list">
    //<li class="quest-item">
    //    <div class="jumbotron">
    //        <h1 class="display-4">@item.Name</h1>
    //        <p class="lead">@item.Description</p>
    //        <hr class="my-4">
    //        <p>Duration: @item.Time</p>
    //        <p class="lead">
    //            <a class="btn btn-primary btn-lg" href="/home/details/@item.Id" role="button">Learn more</a>
    //        </p>
    //    </div>
    //</li>
   // </ ul>
            return new MvcHtmlString(tagUl.ToString());
        }

    }
}