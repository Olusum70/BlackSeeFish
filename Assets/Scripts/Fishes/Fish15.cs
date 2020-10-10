using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish15 : Fish
{

    private void Start()
    {
        xPos = this.gameObject.transform.position.x;
        nameEN = "Common dragonet";
        descriptionEN = "The common dragonet has a broad, triangular, flattened head with a long snout and protruding lower jaw, the body is also flattened, although the tail is rounded. The eyes are placed on the top head and the gills are alo on the upper part of the body. The preopercular bone is strongly hooked and has four robust spines, the front facing forwards and the other three face rearwards. The adults are sexually dimorphic and the mature males have elongate rays in their dorsal and caudal fins. The second dorsal fin is yellowish with bright blue longitudinal stripes and they have bright blue marks on the head and body. The females and immature males are brown, paler on the underside, with a series of 6 brown blotches along their flanks. There are three symmetrical brown saddle-like blotches along the back with indistinct darker longitudinal stripes on their second dorsal fin. The females are normally smaller than the males with an average total length of 20 centimetres (7.9 in) long and the larger males grow up to 30 centimetres (12 in). Their colour and patterning mean that common dragonets are well camouflaged on coarse sand or gravel substrates. When the common dragonet is at rest on the seabed its fins are often folded.";
        speed = 5;
        swimmingLevel = 2;
        endangeredLevel = 0;
    }




}
