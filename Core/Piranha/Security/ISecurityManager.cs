﻿using System;
using System.Collections.Generic;

namespace Piranha.Security
{
	/// <summary>
	/// The security manager is responsible for handling authentication
	/// for users.
	/// </summary>
	public interface ISecurityManager
	{
		/// <summary>
		/// Gets if the currently logged in user is an administrator.
		/// </summary>
		bool IsAdmin { get; }

		/// <summary>
		/// Gets if the current user is authenticated.
		/// </summary>
		bool IsAuthenticated { get; }

		/// <summary>
		/// Gets the currently available roles.
		/// </summary>
		/// <returns>The roles</returns>
		IEnumerable<Role> GetRoles();

		/// <summary>
		/// Logs in the user with the given username and password.
		/// </summary>
		/// <param name="username">The username</param>
		/// <param name="password">The password</param>
		/// <returns>If the user was successfully logged in</returns>
		bool Login(string username, string password);

		/// <summary>
		/// Logs our the currently logged in user.
		/// </summary>
		void Logout();
	}
}
