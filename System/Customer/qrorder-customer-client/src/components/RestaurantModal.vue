<template>
  <div class="modal fade" id="restaurantModal" tabindex="-1">
    <div
      class="modal-dialog modal-dialog-centered modal-dialog-scrollable modal-fullscreen-sm-down"
      style="max-width: 700px">
      <div class="modal-content">
        <ModalHeader />

        <div class="modal-body p-0">
          <h1 class="text-center p-4">Restaurant Detail</h1>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import ModalHeader from "@/components/ModalHeader.vue";

export default {
  components: { ModalHeader },
};
</script>

<style scoped></style>
