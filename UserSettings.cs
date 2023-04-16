using ColossalFramework;
using ColossalFramework.UI;
using ICities;
using System;
using System.Diagnostics;
using UnityEngine;

namespace Mod_Lang_UA.GUI
{
    public class ModOptions
    {
        public ModOptions(UIHelperBase helper, string name)
        {
            try
            {
                UIHelperBase group = helper.AddGroup(name);
                UIPanel panel = ((UIHelper)group).self as UIPanel;

                UILabel header = panel.AddUIComponent<UILabel>();
                header.name = "header";
                header.textScale = 2f;
                header.text = "Користувацька локалізація для Cities: Skyline";

                group.AddSpace(10);

                UILabel credit = panel.AddUIComponent<UILabel>();
                credit.name = "credit";
                credit.textScale = 1.2f;
                credit.text = "Sancho Galician(Shun Akiyama)";
                
                group.AddSpace(20);

                UILabel update_h = panel.AddUIComponent<UILabel>();
                update_h.name = "update_label";
                update_h.textScale = 1.4f;
                update_h.text = "Останнє оновлення 16/04/2023";

                UILabel updated = panel.AddUIComponent<UILabel>();
                updated.name = "update_text";
                updated.textScale = 1.2f;
                updated.text = "Sancho Galician(Shun Akiyama)";
                
                group.AddSpace(20);

            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log("OnSettingsUI failed");
                UnityEngine.Debug.LogException(e);
            }
        }

        public static void OpenUrl(string url)
        {
            Process.Start(url);
        }
    }
}