﻿//******************************************************************************************************
//  SystemController.cs - Gbtc
//
//  Copyright © 2016, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  02/17/2016 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System.Web.Mvc;
using GSF.Web.Model;
using GSF.Web.Security;
using MiPlan.Models;

namespace MiPlan.Controllers
{
    /// <summary>
    /// Represents a MVC controller for the site's system pages.
    /// </summary>
    [AuthorizeControllerRole("Administrator")]
    public class SystemController : Controller
    {
        #region [ Members ]

        // Fields
        private readonly DataContext m_dataContext;
        private readonly AppModel m_appModel;
        private bool m_disposed;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Creates a new <see cref="SystemController"/>.
        /// </summary>
        public SystemController()
        {
            // Establish data context for the view
            m_dataContext = new DataContext(exceptionHandler: MvcApplication.LogException);
            ViewData.Add("DataContext", m_dataContext);

            // Set default model for pages used by layout
            m_appModel = new AppModel(m_dataContext);
            ViewData.Model = m_appModel;
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="SystemController"/> object and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                try
                {
                    if (disposing)
                        m_dataContext?.Dispose();
                }
                finally
                {
                    m_disposed = true;          // Prevent duplicate dispose.
                    base.Dispose(disposing);    // Call base class Dispose().
                }
            }
        }

        public ActionResult Home()
        {
            m_appModel.ConfigureView(Url.RequestContext, "System.Home", ViewBag);
            return View();
        }

        public ActionResult Pages()
        {
            m_appModel.ConfigureView<Page>(Url.RequestContext, "System.Pages", ViewBag);
            return View();
        }

        public ActionResult Menus()
        {
            m_appModel.ConfigureView<Menu>(Url.RequestContext, "System.Menus", ViewBag);
            return View();
        }

        public ActionResult MenuItems()
        {
            m_appModel.ConfigureView<MenuItem>(Url.RequestContext, "System.MenuItems", ViewBag);
            return View();
        }

        public ActionResult ValueListGroups()
        {
            m_appModel.ConfigureView<ValueListGroup>(Url.RequestContext, "System.ValueListGroups", ViewBag);
            return View();
        }

        public ActionResult ValueListItems()
        {
            m_appModel.ConfigureView<ValueList>(Url.RequestContext, "System.ValueListItems", ViewBag);
            return View();
        }

        public ActionResult Theme()
        {
            m_appModel.ConfigureView<Theme>(Url.RequestContext, "System.Theme", ViewBag);
            return View();
        }

        public ActionResult ThemeFields()
        {
            m_appModel.ConfigureView<ThemeFields>(Url.RequestContext, "System.ThemeFields", ViewBag);
            return View();
        }

        public ActionResult SelectTheme()
        {
            m_appModel.ConfigureView(Url.RequestContext, "System.SelectTheme", ViewBag);
            return View();
        }

        #endregion
    }
}