using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace SMSPackages.UILogger
{
    public class UILogger : Singleton<UILogger>
    {
        static Text content;
        static string str_content;

        [SerializeField]
        KeyCode activeKey = KeyCode.Tab;

        public bool active = false;
        public int fontSize = 20;

        public event Action onCollect;
        List<ILogable> loggers;

        void Start()
        {
            loggers = new List<ILogable>();
            content = transform.Find("Logger Text").GetComponent<Text>();
            content.text = "";
            Invoke("RegisterLoggers", 1);
        }

        void OnDestrory()
        {
            RemoveLoggers();
        }

        private void RegisterLoggers()
        {
            GameObject[] gobjects = FindObjectsOfType<GameObject>();

            foreach (GameObject item in gobjects)
            {
                try
                {
                    ILogable[] _loggers = item.GetComponents<ILogable>();
                    foreach (var logItem in _loggers)
                    {
                        onCollect += logItem.CollectLogData;
                        loggers.Add(logItem);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Log(ex.Message);
                }
            }
        }

        private void RemoveLoggers()
        {
            foreach (ILogable logger in loggers)
            {
                onCollect -= logger.CollectLogData;
            }
        }

        void InitText()
        {
            str_content = "";
            Add(Constants.TiitleText());
            Add("Logger Items: " + loggers.Count);
            Add("--------------------------------------------------");
        }

        void Update()
        {
            if (Input.GetKeyDown(activeKey))
            {
                active = !active;
                Show(content);
            }

            if (active)
            {
                InitText();
                Collect();
                ShowContent();
            }
        }

        public static void Add(string content)
        {
            str_content += content + "\n";
        }

        void ShowContent()
        {
            content.text = str_content;
            content.fontSize = fontSize;
        }

        void Show(Text content)
        {
            content.gameObject.SetActive(active);
        }

        void Collect()
        {
            if (onCollect != null)
            {
                onCollect();
            }
        }
    }
}

public class UILogStyle
{
    Color textColor;
    public UILogStyle(Color textColor)
    {
        this.textColor = textColor;
    }
}