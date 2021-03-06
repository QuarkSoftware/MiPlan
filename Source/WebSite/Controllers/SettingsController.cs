﻿//******************************************************************************************************
//  SettingsController.cs - Gbtc
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
//  03/02/2016 - Ritchie Carroll
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
    /// Represents a MVC controller for the site's settings pages.
    /// </summary>
    [AuthorizeControllerRole]
    public class SettingsController : Controller
    {
        #region [ Members ]

        // Fields
        private readonly DataContext m_dataContext;
        private readonly AppModel m_appModel;
        private bool m_disposed;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Creates a new <see cref="SettingsController"/>.
        /// </summary>
        public SettingsController()
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
        /// Releases the unmanaged resources used by the <see cref="SettingsController"/> object and optionally releases the managed resources.
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
            m_appModel.ConfigureView(Url.RequestContext, "Settings.Home", ViewBag);
            return View();
        }

        public ActionResult Vendors()
        {
            m_appModel.ConfigureView<Vendor>(Url.RequestContext, "Settings.Vendors", ViewBag);
            return View();
        }

        public ActionResult Platforms()
        {
            m_appModel.ConfigureView<Platform>(Url.RequestContext, "Settings.Platforms", ViewBag);
            return View();
        }

        public ActionResult BusinessUnits()
        {
            m_appModel.ConfigureView<BusinessUnit>(Url.RequestContext, "Settings.BusinessUnits", ViewBag);
            return View();
        }

        #endregion
    }
}