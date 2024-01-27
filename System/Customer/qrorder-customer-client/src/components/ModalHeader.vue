<template>
  <div class="container-fluid">
    <div class="row px-1">
      <div class="col-9 p-0">
        <div class="navbar">
          <Brand />
        </div>
      </div>
      <div class="col-3 modal-header border-0">
        <button type="button" class="btn-close" data-bs-dismiss="modal" />
      </div>
    </div>
  </div>
</template>

<script>
import Brand from "@/components/Brand.vue";

export default {
  components: { Brand },
};
</script>

<style scoped></style>
