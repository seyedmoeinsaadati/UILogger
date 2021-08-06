# Unity UILogger
<img src="https://github.com/seyedmoeinsaadati/UILogger/blob/main/media/unitylogo.png" align="right" height="50px">
A Simple tools to log data on scene screen in real-time

If you like this project and/or find it useful, please leave a **Star** on this repository.

## Features

  - Log everything (text, properties,...)
  - Default properties (such as fps counter, screen size)

## Do you wanna Demo?

1. Download latest UILogger package.
2. Open it in unity editor.
3. Play "Demo" Scene.
4. Press 'Tab' to enable UILogger.
5. Change cube/camera position to find out how logger works.

## How to use?

1. Create a C# script:

   ```c#
   public class CustomLogger : MonoBehaviour
   {
       void Start()
       {
       }
   
       void Update()
       {
       }
   }
   ```

2. Implement ILogable interface method.

   ```c#
   public class CustomLogger : MonoBehaviour, ILogable
   {
       void Start()
       {
       }
   
       void Update()
       {
       }
       public void CollectLogData()
       {
           // add whatever you want to UILogger
           // use UILogger.Add(string msg) to add data.
           // for example
           // UILogger.Add("Object Position " + transform.position.ToString());
           // to Log object position
       }
   }
   ```

4. In your scene, select 'tools/create UILogger' to create UILogger Object.

4. In UILogger object you can change font size.

5. Play Scene and Press 'Tab' to enable UILogger.

## License

For licensing, contact me at: [saadatimoin@gmail.com](mailto:saadatimoin@gmail.com)

**It is prohibited to sublicense and/or sell copies of this project in stores such as the Unity Asset Store!**

© Seyed Moein Saadati

[![](https://img.shields.io/static/v1?label=Website&message=www.seyedmoeinsaadati.github.io&color=brightgreen)](https://www.seyedmoeinsaadati.github.io)
[![](https://img.shields.io/static/v1?label=G-mail&message=saadatimoin@gmail.com&color=blue)](mailto:saadatimoin@gmail.com)

