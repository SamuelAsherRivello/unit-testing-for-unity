using System.Collections;
using System.Linq;
using NUnit.Framework;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif //UNITY_EDITOR

namespace RMC.UnitTesting.Examples.SceneLoading
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.SceneLoading")]
    public class SceneLoadingPlayModeTest : IPrebuildSetup, IPostBuildCleanup
    {
        private const float DelayForSetupTime = 1f;
        private EditorBuildSettingsScene[] _editorBuildSettingsSceneBackup;

        private string[] _sceneNamesToAdd = new[]
        {
            $"Assets/Unit Testing For Unity/Examples/Workshops/Workshop_08_SceneLoading/Scenes/{SceneLoadingPlayModeTest.Scene01_Intro}.unity",
            $"Assets/Unit Testing For Unity/Examples/Workshops/Workshop_08_SceneLoading/Scenes/{SceneLoadingPlayModeTest.Scene02_Game}.unity",
        };

        public void Setup()
        {
            _editorBuildSettingsSceneBackup = EditorBuildSettings.scenes;

            for (int i = 0; i < _sceneNamesToAdd.Length; i++)
            {
                var newScene = new EditorBuildSettingsScene(_sceneNamesToAdd[i], true);
                var newScenes = EditorBuildSettings.scenes.Append(newScene).ToArray();
                EditorBuildSettings.scenes = newScenes;
                Debug.Log($"Adding EditorBuildSettings.Scenes. Count = {EditorBuildSettings.scenes.Length}");
            }
        }

        public void Cleanup()
        {
            EditorBuildSettings.scenes = _editorBuildSettingsSceneBackup;
            Debug.Log($"Removing EditorBuildSettings.Scenes. Count = {EditorBuildSettings.scenes.Length}");
        }


        private bool _isSceneLoaded = false;
        public static readonly string Scene01_Intro = "Scene01_Intro";
        public static readonly string Scene02_Game = "Scene02_Game";

        /// <summary>
        /// Setup method to initialize the test environment before each test is run
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //Do any setup
        }


        /// <summary>
        /// Teardown method to cleanup the test environment after each test has run
        /// </summary>
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _isSceneLoaded = false;
        }


        [UnityTest]
        public IEnumerator Scene01_Intro__HeroIsNotNull__WhenSceneLoaded()
        {
            // Arrange
            SceneManager.sceneLoaded += (scene, mode) => { _isSceneLoaded = true; };
            SceneManager.LoadScene(Scene01_Intro, LoadSceneMode.Single);

            // Await
            yield return new WaitWhile(() => !_isSceneLoaded);

            // Act
            Hero hero = Resources.FindObjectsOfTypeAll<Hero>().FirstOrDefault();

            // Await

            // Assert
            Assert.That(hero, Is.Not.Null);
        }
        
        [UnityTest]
        public IEnumerator Scene01_Intro__ThrowsNoException__WhenSceneLoadedForSeconds05()
        {
            // Arrange
            SceneManager.sceneLoaded += (scene, mode) => { _isSceneLoaded = true; };

            // Act
            Assert.DoesNotThrow(() =>
            {
                SceneManager.LoadScene(Scene01_Intro, LoadSceneMode.Single);

                // Assert
                while (!_isSceneLoaded && Time.realtimeSinceStartup < DelayForSetupTime)
                {
                    // Await
                }
            });

            yield return null;
        }
        


        [UnityTest]
        public IEnumerator Scene02_Game__HeroIsNotNull__WhenSceneLoaded()
        {
            // Arrange
            SceneManager.sceneLoaded += (scene, mode) => { _isSceneLoaded = true; };
            SceneManager.LoadScene(Scene01_Intro, LoadSceneMode.Single);

            // Await
            yield return new WaitWhile(() => !_isSceneLoaded);

            // Act
            Hero hero = Resources.FindObjectsOfTypeAll<Hero>().FirstOrDefault();

            // Await

            // Assert
            Assert.That(hero, Is.Not.Null);
        }

        [UnityTest]
        public IEnumerator Scene02_Game__ThrowsNoException__WhenSceneLoadedForSeconds05()
        {
            // Arrange
            SceneManager.sceneLoaded += (scene, mode) => { _isSceneLoaded = true; };

            // Act
            Assert.DoesNotThrow(() =>
            {
                SceneManager.LoadScene(Scene02_Game, LoadSceneMode.Single);

                // Assert
                while (!_isSceneLoaded && Time.realtimeSinceStartup < 0.5f)
                {
                    // Await
                }
            });

            yield return null;
        }
    }
}