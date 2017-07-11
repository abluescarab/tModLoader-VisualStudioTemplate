using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace tModLoaderWizard {
    public class WizardImplementation : IWizard {
        private UserInputForm inputForm;

        // This method is called before opening any item that   
        // has the OpenInEditor attribute.  
        public void BeforeOpeningFile(ProjectItem projectItem) {
        }

        public void ProjectFinishedGenerating(Project project) {
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public void ProjectItemFinishedGenerating(ProjectItem
            projectItem) {
        }

        // This method is called after the project is created.  
        public void RunFinished() {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind,
            object[] customParams) {
            string destinationDirectory = replacementsDictionary["$destinationdirectory$"];

            try {
                // Display a form to the user. The form collects input for the custom message.  
                inputForm = new UserInputForm();
                
                if(inputForm.ShowDialog(replacementsDictionary["$safeprojectname$"]) != DialogResult.OK) {
                    throw new WizardBackoutException();
                }

                foreach(Tuple<string, string> param in UserInputForm.parameters) {
                    replacementsDictionary.Add(param.Item1, param.Item2);
                }
            }
            catch(Exception ex) {
                // Clean up the template that was written to disk
                if(Directory.Exists(destinationDirectory)) {
                    Directory.Delete(destinationDirectory, true);
                }

                Debug.WriteLine(ex);

                throw;
            }
        }

        // This method is only called for item templates,  
        // not for project templates.  
        public bool ShouldAddProjectItem(string filePath) {
            return true;
        }
    }
}
