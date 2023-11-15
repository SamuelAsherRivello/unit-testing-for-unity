using NUnit.Framework;
using UnityEditor;
using UnityEngine;


namespace RMC.UnitTesting.Examples.Prefab
{
    /// <summary>
    /// This Unit Test validates that code executes as expected.
    /// </summary>
    [Category("RMC.UnitTesting.Examples.Prefab")]
    public class PrefabPlayModeTest
    {
        private const float DelayForSetupTime = 0.5f;
        private const string EnemyPrefabPath = 
            "Assets/Unit Testing For Unity/Examples/Workshops/Workshop_07_Prefab/Scripts/Prefabs/Enemy.prefab";

        private Enemy _enemy;

        /// <summary>
        /// Setup method to initialize the test environment before each test is run
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            // Load a prefab (by giving it the path to an existing prefab).
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(EnemyPrefabPath);
            
            // Instantiate the prefab
            GameObject go = GameObject.Instantiate(prefab, new Vector3(0, 0, 10), new Quaternion(0, 180, 0, 0));
            _enemy = go.GetComponent<Enemy>();
            
            // Wait for three seconds (Arbitrary time for prefab to set up itself).
            while (Time.realtimeSinceStartup < DelayForSetupTime)
            {
                // Wait
            }
        }

     

        /// <summary>
        /// Teardown method to cleanup the test environment after each test has run
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            if (_enemy != null)
            {
                Object.DestroyImmediate(_enemy.gameObject);
                _enemy = null;
            }
        }

        [Test]
        public void Enemy_EnemyIsNotNull_WhenPrefabInstantiated()
        {
            // Arrange
    
            // Act

            // Assert
            Assert.That(_enemy, Is.Not.Null);
 
        }
        
        [Test]
        public void Enemy_GameObjectIsNotNull_WhenPrefabInstantiated()
        {
            // Arrange
    
            // Act

            // Assert
            Assert.That(_enemy.gameObject, Is.Not.Null);
        }
        
        [Test]
        public void Enemy_RigidBodyIsNotNull_WhenPrefabInstantiated()
        {
            // Arrange
    
            // Act

            // Assert
            Assert.That(_enemy.Rigidbody, Is.Not.Null);
        }

    }
}