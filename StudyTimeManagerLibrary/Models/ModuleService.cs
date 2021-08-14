using System;
using System.Collections.Generic;
using System.Linq;
namespace StudyTimeManagerLibrary.Models
{
    class ModuleService
    {
        private static List<Module>? modules;
        public ModuleService() => modules = new List<Module>();

        /// <summary>
        /// Returns list of modules
        /// </summary>
        /// <returns></returns>
        public List<Module> GetAll() => modules!;
        
        /// <summary>
        /// Adds new module to modules list
        /// </summary>
        /// <param name="module">new module</param>
        /// <returns></returns>
        public void Add(Module module)
        {
            //validate new module
            if (ValidateNewModule(module))
            {
                //add module
                modules!.Add(module);
            }
        }

        #region module property validation methods
        /// <summary>
        /// Validates new module's properties
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        private bool ValidateNewModule(Module module) => ValidateName(module.Name!) && ValidateCode(module.Code!);

        /// <summary>
        /// Checks if module name is null or empty
        /// </summary>
        /// <param name="moduleName">module name</param>
        /// <returns></returns>
        private bool ValidateName(string moduleName) => !String.IsNullOrEmpty(moduleName);
        
        /// <summary>
        /// Validate whether module is null or empty
        /// </summary>
        /// <param name="moduleCode"></param>
        /// <returns></returns>
        private bool ValidateCode(string moduleCode) => !String.IsNullOrEmpty(moduleCode);

        /// <summary>
        /// Validate module credits
        /// </summary>
        /// <param name="moduleCredits"></param>
        /// <returns></returns>
        //private bool ValidateCredits(string moduleCredits) => !string.IsNullOrEmpty(moduleCredits) && int.TryParse(moduleCredits, out _);
        #endregion
    }
}
