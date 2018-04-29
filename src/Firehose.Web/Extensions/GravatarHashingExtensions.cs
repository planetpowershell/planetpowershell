using Firehose.Web.Infrastructure;
using System.Configuration;
using System.Web;

namespace Firehose.Web.Extensions
{
    public static class GravatarHashingExtensions
    {
        public static string GravatarImage(this IAmACommunityMember member)
        {
            const int size = 200;
            var hash = member.GravatarHash;

            var defaultImage = HttpUtility.UrlEncode(ConfigurationManager.AppSettings["DefaultGravatarImage"]);
            return $"//www.gravatar.com/avatar/{hash}.jpg?s={size}&d={defaultImage}";
        }
    }
}