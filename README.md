# EtoGtkReseourceLeakTest

This demonstrates the slow leak in the Eto.Forms/GtkSharp Drawable object over time - the text and bar graphs are all updated at 100ms 
intervals and the app will slowly eat memory in the GTK version. The start/stop button will start the update process.  the Toggle Update 
bvutton, stills runs the background task but does not upadte the controls. 


