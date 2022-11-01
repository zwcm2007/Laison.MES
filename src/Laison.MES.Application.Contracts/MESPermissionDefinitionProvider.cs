using Laison.MES.Domain.Shared;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Laison.MES.Application.Contracts
{
    /// <summary>
    /// 权限定义
    /// </summary>
    public class MESPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            // 用户相关权限
            var group = context.AddGroup(MESPermissions.UserGroup, L("Permission:UserManagement"));

            var permission = group.AddPermission(MESPermissions.Users.Default, L("Permission:UserManagement"));
            permission.AddChild(MESPermissions.Users.Get, L("Permission:UsersGet"));
            permission.AddChild(MESPermissions.Users.Create, L("Permission:UsersCreate"));
            permission.AddChild(MESPermissions.Users.Update, L("Permission:UsersUpdate"));
            permission.AddChild(MESPermissions.Users.Delete, L("Permission:UsersDelete"));
            permission.AddChild(MESPermissions.Users.Export, L("Permission:UsersExport"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MESResource>(name);
        }
    }
}