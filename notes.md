# Stuff I will definitely forget eventually

## Github Actions
#### Visibility
Actions won't even show up until they are triggered for the first time. Dropping a `main.yml` file in `.github/workflows` is totally fine, but it won't show up in the web ui until it is successfully triggered once.

#### Push your tags!
Actions won't trigger till you actually push the tag. Tags get put on the head.
```bash
#...git commit whatever
git tag v-whatever
git push origin tag v-whatever
```

#### Pipeline shenanigans
`.github/workflows/main.yml` has to be updated to reference the correct headless server artifact and template file at `https://downloads.tuxfamily.org/godotengine/` every time I upgrade Godot.