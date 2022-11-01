using Volo.Abp.Reflection;

namespace Laison.MES.Application.Contracts
{
    /// <summary>
    /// 权限定义
    /// </summary>
    public class MESPermissions
    {
        public const string UserGroup = "UserGroup";

        public static class Users
        {
            public const string Default = "Users";
            public const string Get = Default + ".Get";
            public const string Create = Default + ".Create";
            public const string Update = Default + ".Update";
            public const string Delete = Default + ".Delete";
            public const string Export = Default + ".Export";
        }


        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(MESPermissions));
        }
    }
}