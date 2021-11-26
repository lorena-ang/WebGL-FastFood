# WebGL-FastFood
Individual project for my Computer Graphics class using Unity and WebGL to create a 3D scene.
- Link to access the completed project: https://simmer.io/@loreang98/fastfood-a01039980
- Link to video demo using simmer.io upload: https://drive.google.com/file/d/13rMcYhsuoWSnRAJyL_oaITmNa87whs2S/view?usp=sharing

### Scene
The inside of a fast food restaurant. There will be one counter with a cash register and some tables and chairs. The objects will need to cast shadows according to the illumination present. If there is time to do so, food will also be added to the tables. Rough sketch of the desired scene, which can be expanded:

<img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/SceneSketch.png" width="500">
* Tools: Unity to create the scene using 3D objects in .fbx and .obj format, as well as to add textures and materials. The Unity scene will then be exported as a WebGL file (https://learn.unity.com/tutorial/how-to-publish-for-webgl?signup=true#5d92519bedbc2a130fa21789).

## Plan

### First version
Base objects and elements added to the scene without completed textures/materials/illumination/shadows.
<img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version1.png" width="600" height="360">
<img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version1.1.png" width="600" height="360">
<img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version1.2.png" width="600" height="360">

### Second version
Completed scene with all textures and materials.

<img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version2.png" width="600" height="360"><img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version2.1.png" width="600" height="360"><img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version2.2.png" width="600" height="360">

### Final version
Completed scene with logo animation, interactive controls, illumination and shadows.
<img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version3.png" width="600" height="360"><img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version3.1.png" width="600" height="360"><img src="https://github.com/lorena-ang/WebGL-FastFood/blob/main/Images/Version3.2.png" width="600" height="360">

## Execution

### 3D Objects used

#### With Royalty Free Licenses
  - Walls (https://www.cgtrader.com/free-3d-models/architectural/engineering/concrete-wall)
  - Restaurant logo (https://www.cgtrader.com/free-3d-models/various/various-models/mcdonalds-logo-and-mcdonalds-sign-board)
  - Counter (https://www.cgtrader.com/free-3d-models/furniture/table/reception-desk--9)
  - Cash register (https://www.cgtrader.com/free-3d-models/various/various-models/cash-register-machine)
  - Tables (https://assetstore.unity.com/packages/3d/props/interior/modern-table-with-chairs-83834)
  - Chairs (https://assetstore.unity.com/packages/3d/props/interior/modern-table-with-chairs-83834)
  - Sitting booths (https://www.cgtrader.com/free-3d-models/interior/other/restaurant-table-set)
  - Ceiling lamps (https://www.cgtrader.com/free-3d-models/various/various-models/lamp-05-am152)
  - Window panes (https://www.cgtrader.com/free-3d-models/architectural/window/aluprof-mb-skyline-m-0001)
  - Door with windows (https://www.cgtrader.com/free-3d-models/architectural/window/aluprof-mb-60e-ei-005-m-0336)
  - Fast food (https://www.cgtrader.com/free-3d-models/food/miscellaneous/low-poly-burger-meal)

#### Created using Unity
- Walls
- Floor

### Textures and materials

#### Materials/images obtained from online sources
  - Walls (https://assetstore.unity.com/packages/2d/textures-materials/brick/high-quality-bricks-walls-49581, https://assetstore.unity.com/packages/2d/textures-materials/4k-materials-191322)
  - Floor (https://assetstore.unity.com/packages/2d/textures-materials/wood/yughues-free-wooden-floor-materials-13213)
  - Black wooden part of counter (https://www.myfreetextures.com/white-seamless-wood-background-texture/)
  - Fast food (https://www.cgtrader.com/free-3d-models/food/miscellaneous/low-poly-burger-meal)
  - Cash register screen image (https://erply.com/uk/online-cash-register/)

#### Materials created using Unity
  - Tables
  - Chairs
  - Yellow walls
  - Ceiling
  - Solid colors
  - Metals

### Controls and Animation
- 3D restaurant logo rotating on its axis
- Cursor: Camera perspective
- WASD/Arrows: Movement
- Spacebar: Shows/hide ceiling and front wall
