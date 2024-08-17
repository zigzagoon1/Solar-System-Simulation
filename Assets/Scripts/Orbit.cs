/*The data used for calculating the planetory orbits in this simulation comes from NASA.
I followed their formula for approximate positions of the planets, which inherently comes 
with some errors. If you would like to see the data and formula used, or learn more about 
this topic in general, visit https://ssd.jpl.nasa.gov/planets/approx_pos.html#tables
*/

using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]
    Transform sun;

    [SerializeField]
    float distance;

    [SerializeField]
    float speed;

    private void Update()
    {
        OrbitSun();
    }

    void OrbitSun()
    {
        transform.RotateAround(sun.transform.position, Vector3.up, speed * Time.deltaTime);
        transform.position = (transform.position - sun.position).normalized * distance + sun.position;
    }
}
